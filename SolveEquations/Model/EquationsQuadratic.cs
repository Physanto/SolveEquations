using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ProjectIntegrated2.Model
{
    internal class EquationsQuadratic
    {

        public List<string> FunctionMainSolverQuadratic(string equation, char option)
        {
            bool ok = false;

            List<string> procedimiento = new List<string>();

            if (ValidateQuadraticEquation(equation))
            {
                MessageBox.Show("La ecuación es correcta.", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ok = true;
            }
            else
            {
                MessageBox.Show("La ecuación no es válida. Asegúrate de introducirla en la forma ax^2 + bx + c = 0", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                ok = false;
            }

            if (ok == true)
            {
                var coefficients = ExtractCoefficients(equation);
                double a = coefficients.Item1; double b = coefficients.Item2; double c = coefficients.Item3;

                if (option == '1')
                {
                    procedimiento = SolveQuadraticEquationByFormula(a, b, c, equation).steps;
                }
                else if (option == '2')
                {
                    procedimiento = SolveQuadraticEquationByCompletingSquare(a, b, c, equation);
                }

                return procedimiento;
            }
            else procedimiento.Add("");

            return procedimiento;
        }
        static double ConvertToDouble(string value, double defaultValue)
        {
            if (string.IsNullOrEmpty(value)) return defaultValue;
            if (value == "-") return -1;
            if (value == "+") return 1;
            return double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double result) ? result : defaultValue;
        }
        public bool ValidateQuadraticEquation(string equation)
        {
            string pattern = @"^([-+]?\d*\.?\d*)[a-z]\^2([-+]?\d*\.?\d*)[a-z]([-+]?\d*\.?\d*)=0$";
            return Regex.IsMatch(equation, pattern, RegexOptions.IgnoreCase);
        }

        public Tuple<double, double, double> ExtractCoefficients(string equation)
        {
            string pattern = @"^(?<a>[-+]?\d*\.?\d*)[a-z]?\^2(?<b>[-+]?\d*\.?\d*)?[a-z]?(?<c>[-+]?\d*\.?\d*)?=0$";
            var match = Regex.Match(equation, pattern, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                MessageBox.Show("Ingrese una ecuación válida", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            string aStr = match.Groups["a"].Value; string bStr = match.Groups["b"].Value; string cStr = match.Groups["c"].Value;

            double a = ConvertToDouble(aStr, 1);
            double b = string.IsNullOrEmpty(bStr) ? 0 : ConvertToDouble(bStr, 0);
            double c = string.IsNullOrEmpty(cStr) ? 0 : ConvertToDouble(cStr, 0);

            return Tuple.Create(a, b, c);
        }

        public (List<string> steps, List<double> xs) SolveQuadraticEquationByFormula(double a, double b, double c, string equation)
        {
            List<double> xs = new List<double>();

            List<string> steps = new List<string>
                {
                    $"\n\t\t\tEcuación original: {FormatEquation(equation)}",
                    $"\n\t\t\tCoeficientes identificados: a = {a}, b = {b}, c = {c}"
                };

            double discriminant = b * b - 4 * a * c;
            steps.Add($"\n\t\t\tDiscriminante: Δ = b² - 4ac = {b}² - 4*{a}*{c} = {discriminant}");

            if (discriminant < 0)
            {
                steps.Add("\n\t\t\tLa ecuación no tiene soluciones reales.");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                steps.Add($"\n\t\t\tSolución única: x = -b / (2a) = -{b} / (2*{a}) = {x}");
            }
            else
            {
                double sqrtDiscriminant = Math.Sqrt(discriminant);
                steps.Add($"\t\t\t√Δ = √{discriminant} = {sqrtDiscriminant}");

                double x1 = (-b + sqrtDiscriminant) / (2 * a);
                double x2 = (-b - sqrtDiscriminant) / (2 * a);

                xs.Add(x1);
                xs.Add(x2);

                steps.Add("\n\n\t\t\tSoluciones:\n");
                steps.Add($"\n\t\t\t1 = (-b + √Δ) / (2a) = (-{b} + {sqrtDiscriminant}) / (2*{a}) = {x1}");
                steps.Add($"\n\t\t\t2 = (-b - √Δ) / (2a) = (-{b} - {sqrtDiscriminant}) / (2*{a}) = {x2}");
            }

            return (steps, xs);
        }

        static List<string> SolveQuadraticEquationByCompletingSquare(double a, double b, double c, string equation)
        {
            List<string> steps = new List<string>
                {
                    $"\n\t\t\tEcuación original: {FormatEquation(equation)}",
                    $"\n\t\t\tCoeficientes identificados: a = {a}, b = {b}, c = {c}"
                };

            if (a == 0)
            {
                steps.Add("\n\t\t\tNo es una ecuación cuadrática (a = 0).");
                return steps;
            }

            double aInv = 1 / a;
            double bA = b * aInv;
            double cA = c * aInv;

            steps.Add($"\n\t\t\tDividir todos los términos por {a}: x^2 {FormatSign(bA)} {Math.Abs(bA)}x {FormatSign(cA)} {Math.Abs(cA)} = 0");
            steps.Add($"\n\t\t\tMover {Math.Abs(cA)} al otro lado: x^2 {FormatSign(bA)} {Math.Abs(bA)}x = {FormatSign(-cA)} {Math.Abs(-cA)}");

            double halfB = bA / 2;
            double squareHalfB = halfB * halfB;

            steps.Add($"\n\t\t\tCompletar el cuadrado sumando y restando ({halfB})^2: x^2 {FormatSign(bA)} {Math.Abs(bA)}x + ({halfB})^2 = {FormatSign(-cA)} {Math.Abs(-cA)} + ({halfB})^2");
            double rhs = -cA + squareHalfB;
            steps.Add($"\n\t\t\tSimplificar: (x {FormatSign(halfB)})^2 = {rhs}");

            if (rhs < 0)
            {
                steps.Add("\n\t\t\tLa ecuación no tiene soluciones reales.");
            }
            else
            {
                double sqrtRhs = Math.Sqrt(rhs);
                double x1 = -halfB + sqrtRhs;
                double x2 = -halfB - sqrtRhs;

                steps.Add("\n\n\t\t\tSoluciones:\n");
                steps.Add($"\n\t\t\t1 = {FormatSign(-halfB)} {Math.Abs(halfB)} + √{rhs} = {x1}");
                steps.Add($"\n\t\t\t2 = {FormatSign(-halfB)} {Math.Abs(halfB)} - √{rhs} = {x2}\n");
            }

            return steps;
        }

        static string FormatSign(double value)
        {
            return value > 0 ? "+" : "-";
        }

        static string FormatEquation(string equation)
        {
            return equation.Replace("=", " = ");
        }
    }
}
