using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectIntegrated2.Model
{
    internal class Factorization
    {
        public List<string> FunctionMainFactorizer(string equation, char option)
        {
            bool ok = false;

            List<string> procedimiento = new List<string>();

            if (ValidateEquation(equation))
            {
                MessageBox.Show("La ecuación es correcta.", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ok = true;
            }
            else
            {
                MessageBox.Show("La ecuación no es válida. Asegúrate de introducirla de una forma válida", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                ok = false;
            }

            if (ok)
            {
                var coefficients = ExtractCoefficients(equation);
                double a = coefficients.Item1; double b = coefficients.Item2; double c = coefficients.Item3;

                bool isQuadratic = c != 0 || a != 0 && b != 0; // Determina si la ecuación es cuadrática

                if (option == '1')
                {
                    procedimiento = FactorByCommonFactor(a, b, c, equation);
                }
                else if (option == '2')
                {
                    procedimiento = FactorByDifferenceOfSquares(a, b, c, equation);
                }

                if (isQuadratic)
                {
                    procedimiento.Add($"Coeficientes identificados: a = {a}, b = {b}, c = {c}");
                }
                else
                {
                    procedimiento.Add($"Coeficientes identificados: a = {a}, b = {b}");
                }

                return procedimiento;
            }
            else procedimiento.Add("");

            return procedimiento;
        }

        static bool ValidateEquation(string equation)
        {
            string patternQuadratic = @"^([-+]?\d*\.?\d*)[a-z]?\^2([-+]?\d*\.?\d*)[a-z]?([-+]?\d*\.?\d*)?$";
            string patternLinear = @"^([-+]?\d*\.?\d*)[a-z]([-+]?\d*\.?\d*)?$";
            return Regex.IsMatch(equation, patternQuadratic, RegexOptions.IgnoreCase) || Regex.IsMatch(equation, patternLinear, RegexOptions.IgnoreCase);
        }

        static Tuple<double, double, double> ExtractCoefficients(string equation)
        {
            string patternQuadratic = @"^(?<a>[-+]?\d*\.?\d*)[a-z]?\^2(?<b>[-+]?\d*\.?\d*)?[a-z]?(?<c>[-+]?\d*\.?\d*)?$";
            string patternLinear = @"^(?<a>[-+]?\d*\.?\d*)(?<var>[a-z])(?<b>[-+]?\d*\.?\d*)?$";
            var match = Regex.Match(equation, patternQuadratic, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                match = Regex.Match(equation, patternLinear, RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    MessageBox.Show("Ingrese una ecuación válida", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                string aStr = match.Groups["a"].Value; string bStr = match.Groups["b"].Value;

                double a = ConvertToDouble(aStr, 1); double b = ConvertToDouble(bStr, 0);

                return Tuple.Create(a, b, 0.0);
            }
            else
            {
                string aStr = match.Groups["a"].Value; string bStr = match.Groups["b"].Value; string cStr = match.Groups["c"].Value;

                double a = ConvertToDouble(aStr, 1);
                double b = string.IsNullOrEmpty(bStr) ? 0 : ConvertToDouble(bStr, 0);
                double c = string.IsNullOrEmpty(cStr) ? 0 : ConvertToDouble(cStr, 0);

                return Tuple.Create(a, b, c);
            }
        }

        static double ConvertToDouble(string value, double defaultValue)
        {
            if (string.IsNullOrEmpty(value)) return defaultValue;
            if (value == "-") return -1;
            if (value == "+") return 1;
            return double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double result) ? result : defaultValue;
        }

        static List<string> FactorByCommonFactor(double a, double b, double c, string equation)
        {
            List<string> steps = new List<string>
             {
             $"\n\t\t\tEcuación original: {FormatEquation(equation)}",
             };

            if (c == 0)
            {
                if (a != 0 && b != 0)
                {
                    double gcd = GCD(a, b);
                    steps.Add($"\n\t\t\tMáximo común divisor de {a} y {b} es {gcd}");
                    steps.Add($"\n\t\t\tFactor común: {gcd}x({FormatTerm(a / gcd, "x")} {FormatSign(b)} {FormatTerm(Math.Abs(b / gcd), "")})");
                }
                else
                {
                    steps.Add("\n\t\t\tLa ecuación no tiene términos válidos para factorización.");
                }
            }
            else
            {
                double gcd = GCD(GCD(a, b), c);

                steps.Add($"\n\t\t\tMáximo común divisor de {a}, {b} y {c} es {gcd}");
                steps.Add($"\n\t\t\tFactor común: {gcd}({FormatTerm(a / gcd, "x^2")} {FormatSign(b)} {FormatTerm(Math.Abs(b / gcd), "x")} {FormatSign(c)} {FormatTerm(Math.Abs(c / gcd), "")})");

                if (gcd != 1)
                {
                    steps.Add($"\n\t\t\tFactor común extraído: {gcd}({FormatTerm(a / gcd, "x^2")} {FormatSign(b)} {FormatTerm(Math.Abs(b / gcd), "x")} {FormatSign(c)} {FormatTerm(Math.Abs(c / gcd), "")})");
                }
            }

            return steps;
        }

        static List<string> FactorByDifferenceOfSquares(double a, double b, double c, string equation)
        {
            List<string> steps = new List<string>
            {
               $"\n\t\t\tEcuación original: {FormatEquation(equation)}",
               $"\n\t\t\tCoeficientes identificados: a = {a}, b = {b}, c = {c}"
            };

            if (b == 0 && a == c)
            {
                double sqrtA = Math.Sqrt(a);
                steps.Add($"\n\t\t\tFactorizando como diferencia de cuadrados: {a}x^2 {FormatSign(-c)} ({sqrtA}x {FormatSign(sqrtA)})({sqrtA}x {FormatSign(-sqrtA)})");
            }
            else
            {
                steps.Add("\n\t\t\tLa ecuación no se puede factorizar como una diferencia de cuadrados.");
            }

            return steps;
        }

        static string FormatSign(double value)
        {
            return value >= 0 ? "+" : "-";
        }


        static double GCD(double a, double b)
        {
            if (b == 0) return Math.Abs(a);
            return GCD(b, a % b);
        }

        static string FormatEquation(string equation)
        {
            return equation.Replace("=", " = ");
        }

        static string FormatTerm(double coefficient, string variable)
        {
            string formattedCoefficient = coefficient == 1 ? "" : Math.Abs(coefficient).ToString();
            return $"{formattedCoefficient}{variable}";
        }

        //public void SolveTrinomialAx()
        //{
        //    static bool ValidateEquation(string equation)
        //    {
        //        string pattern = @"^([-+]?\d*\.?\d*)[a-z]\^2([-+]?\d*\.?\d*)[a-z]([-+]?\d*\.?\d*)=0$";
        //        return Regex.IsMatch(equation, pattern, RegexOptions.IgnoreCase);
        //    }

        //    static double ConvertDouble(string value, double defaultValue)
        //    {
        //        if (string.IsNullOrEmpty(value)) return defaultValue;
        //        if (value == "-") return -1;
        //        if (value == "+") return 1;
        //        return double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double result) ? result : defaultValue;
        //    }

        //    static Tuple<double, double, double> ExtractCoeficients(string equation)
        //    {
        //        string pattern = @"^(?<a>[-+]?\d*\.?\d*)[a-z]?\^2(?<b>[-+]?\d*\.?\d*)?[a-z]?(?<c>[-+]?\d*\.?\d*)?=0$";
        //        var match = Regex.Match(equation, pattern, RegexOptions.IgnoreCase);

        //        if (!match.Success)
        //        {
        //            MessageBox.Show("Ingrese una ecuación válida", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        //        }

        //        string aStr = match.Groups["a"].Value; string bStr = match.Groups["b"].Value; string cStr = match.Groups["c"].Value;

        //        double a = ConvertDouble(aStr, 1);
        //        double b = string.IsNullOrEmpty(bStr) ? 0 : ConvertDouble(bStr, 0);
        //        double c = string.IsNullOrEmpty(cStr) ? 0 : ConvertDouble(cStr, 0);

        //        return Tuple.Create(a, b, c);
        //    }

        //    static (List<string> steps, List<double> xs) SolveByFormula(double a, double b, double c, string equation)
        //    {
        //        List<double> xs = new List<double>();

        //        List<string> steps = new List<string>
        //        {
        //            $"\n\t\t\tEcuación original: {FormatEquation(equation)}",
        //            $"\n\t\t\tCoeficientes identificados: a = {a}, b = {b}, c = {c}"
        //        };

        //        double discriminant = b * b - 4 * a * c;

        //        if (discriminant < 0)
        //        {
        //            steps.Add("\n\t\t\tNo se puede factorizar.");
        //        }
        //        else if (discriminant == 0)
        //        {
        //            double x = -b / (2 * a);
        //            steps.Add($"\n\t\t\tSolución única: x = -b / (2a) = -{b} / (2*{a}) = {x}");
        //        }
        //        else
        //        {
        //            double sqrtDiscriminant = Math.Sqrt(discriminant);

        //            double x1 = (-b + sqrtDiscriminant) / (2 * a);
        //            double x2 = (-b - sqrtDiscriminant) / (2 * a);

        //            xs.Add(x1);
        //            xs.Add(x2);

        //            steps.Add("\n\n\t\t\tSoluciones:\n");
        //        }

        //        return (steps, xs);
        //    }
    }
}
