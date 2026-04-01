using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjectIntegrated2.Model
{
    internal class Systems2x2
    {
        public List<string> FunctionMainSystems2x2(string equationOne, string equationTwo, char option)
        {
            List<string> steps = new List<string>();

            if (!ValidarEcuacion(equationOne) || !ValidarEcuacion(equationTwo))
            {
                MessageBox.Show("Una o ambas ecuaciones no tienen un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Las Ecuaciones están correctas.", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var coeficientsOne = ExtraerCoeficientes(equationOne);
                var coeficientsTwo = ExtraerCoeficientes(equationTwo);

                double a1 = coeficientsOne.Item1;
                double b1 = coeficientsOne.Item2;
                double c1 = coeficientsOne.Item3;

                double a2 = coeficientsTwo.Item1;
                double b2 = coeficientsTwo.Item2;
                double c2 = coeficientsTwo.Item3;


                switch (option)
                {
                    case '1':
                        steps = ResolverPorSustitucion(a1, b1, c1, a2, b2, c2).steps;
                        break;
                    case '2':
                        steps = ResolverPorEliminacion(a1, b1, c1, a2, b2, c2).steps;
                        break;
                    case '3':
                        steps = ResolverPorIgualacion(a1, b1, c1, a2, b2, c2).steps;
                        break;
                }
            }
            return steps;
        }

        static bool ValidarEcuacion(string ecuacion)
        {
            string patternequation = @"^([-+]?\d*\.?\d*)[a-zA-Z]?\s*([-+]\s*\d*\.?\d*)[a-zA-Z]?\s*=\s*([-+]?\d*\.?\d*)?$";
            return Regex.IsMatch(ecuacion.Replace(" ", ""), patternequation, RegexOptions.IgnoreCase);
        }

        public Tuple<double, double, double> ExtraerCoeficientes(string ecuacion)
        {
            string patternequation = @"^(?<a>[-+]?\d*\.?\d*)[a-zA-Z]?\s*(?<b>[-+]\s*\d*\.?\d*)?[a-zA-Z]?\s*=\s*(?<c>[-+]?\d*\.?\d*)?$";
            var match = Regex.Match(ecuacion.Replace(" ", ""), patternequation, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                MessageBox.Show("Formato de ecuación no válido.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            string aStr = match.Groups["a"].Value; string bStr = match.Groups["b"].Value; string cStr = match.Groups["c"].Value;

            double a = ConvertToDouble(aStr, 1);
            double b = string.IsNullOrEmpty(bStr) ? 0 : ConvertToDouble(bStr, 0);
            double c = string.IsNullOrEmpty(cStr) ? 0 : ConvertToDouble(cStr, 0);

            return Tuple.Create(a, b, c);
        }
        static double ConvertToDouble(string value, double defaultValue)
        {
            if (string.IsNullOrEmpty(value)) return defaultValue;
            if (value == "-") return -1;
            if (value == "+") return 1;
            return double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double result) ? result : defaultValue;
        }
        public (List<string> steps, List<double> xs) ResolverPorSustitucion(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            var procedimiento = new List<string>();
            List<double> xs = new List<double>();

            procedimiento.Add("\n\t\t\tMétodo de sustitución");

            double x, y;

            if (a1 != 0)
            {
                procedimiento.Add("\n\t\t\tResolviendo la ecuación 1 para x:");
                procedimiento.Add($"\n\t\t\tx = ({FormatEquation(FormatTerm(c1, ""))} {FormatSign(b1)} {FormatTerm(Math.Abs(b1), "")} * y) / {FormatTerm(a1, "")}");
                x = (c1 - b1 * c2 / b2) / (a1 - b1 * a2 / b2);
                xs.Add(x);
                procedimiento.Add($"\t\t\tx = ({FormatEquation(FormatTerm(c1, ""))} {FormatSign(b1)} {FormatTerm(Math.Abs(b1), "")} * {FormatTerm(c2, "")} / {FormatTerm(b2, "")}) / ({FormatTerm(a1, "")} - {FormatEquation(FormatTerm(b1, ""))} * {FormatTerm(a2, "")} / {FormatTerm(b2, "")})");
                procedimiento.Add($"\t\t\tx = {x}");

                procedimiento.Add("\n\t\t\tResolviendo la ecuación 2 para y:");
                procedimiento.Add($"\n\t\t\ty = ({FormatTerm(c2, "")} {FormatSign(a2)} {FormatTerm(Math.Abs(a2), "")} * x) / {FormatTerm(b2, "")}");
                y = (c2 - a2 * x) / b2;
                xs.Add(y);
                procedimiento.Add($"\t\t\ty = ({FormatTerm(c2, "")} {FormatSign(a2)} {FormatTerm(Math.Abs(a2), "")} * {FormatTerm(x, "")}) / {FormatTerm(b2, "")}");
                procedimiento.Add($"\t\t\ty = {y}");
            }
            else
            {
                procedimiento.Add("\n\t\t\tLa ecuación 1 no puede resolverse para x directamente.");
                procedimiento.Add("\n\t\t\tResolviendo la ecuación 1 para y:");
                procedimiento.Add($"\t\t\ty = {FormatTerm(c1, "")} / {FormatTerm(b1, "")}");
                y = c1 / b1;
                xs.Add(y);
                procedimiento.Add($"\t\t\ty = {y}");

                procedimiento.Add("\n\t\t\tResolviendo la ecuación 2 para x:");
                procedimiento.Add($"\n\t\t\tx = ({FormatTerm(c2, "")} {FormatSign(b2)} {FormatTerm(Math.Abs(b2), "")} * y) / {FormatTerm(a2, "")}");
                x = (c2 - b2 * y) / a2;
                xs.Add(x);
                procedimiento.Add($"\t\t\tx = ({FormatEquation(FormatTerm(c2, ""))} {FormatSign(b2)} {FormatTerm(Math.Abs(b2), "")} * {FormatTerm(y, "")}) / {FormatTerm(a2, "")}");
                procedimiento.Add($"\t\t\tx = {x}");
            }

            procedimiento.Add($"\n\t\t\tLa solución es: x = {x}, y = {y}");

            return (procedimiento, xs);
        }


        public (List<string> steps, List<double> xs) ResolverPorEliminacion(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            List<double> xs = new List<double>();
            var procedimiento = new List<string>();
            procedimiento.Add("\n\t\t\tMétodo de eliminación");

            double x, y;
            double factor = a2 / a1;
            procedimiento.Add($"\n\t\t\tMultiplicando la primera ecuación por {FormatTerm(factor, "")} y restándola de la segunda ecuación:");
            procedimiento.Add($"\n\t\t\t{FormatEquation(FormatTerm(a2, "x"))}x {FormatSign(b2)} {FormatTerm(Math.Abs(b2), "y")} = {c2} - ({FormatTerm(factor, "")} * ({FormatTerm(a1, "x")} {FormatSign(b1)} {FormatTerm(Math.Abs(b1), "y")}) = {FormatTerm(factor * c1, "")})");
            double new_b = b2 - factor * b1;
            double new_c = c2 - factor * c1;
            procedimiento.Add($"\n\t\t\tNueva ecuación: {FormatEquation(FormatTerm(new_b, "y"))} = {new_c}");

            y = new_c / new_b;
            xs.Add(y);
            procedimiento.Add($"\n\t\t\tResolviendo para y:");
            procedimiento.Add($"\n\t\t\ty = {FormatTerm(new_c, "")} / {FormatTerm(new_b, "")}");
            procedimiento.Add($"\t\t\ty = {y}");

            procedimiento.Add("\n\t\t\tSustituyendo el valor de y en la primera ecuación:");
            procedimiento.Add($"\n\t\t\t{FormatEquation(FormatTerm(a1, "x"))}x {FormatSign(b1)} ({FormatTerm(y, "")}) = {c1}");
            x = (c1 - b1 * y) / a1;
            xs.Add(x);
            procedimiento.Add($"\t\t\tx = ({FormatTerm(c1, "")} {FormatSign(b1)} {FormatTerm(Math.Abs(b1), "")} * {FormatTerm(y, "")}) / {FormatTerm(a1, "")}");
            procedimiento.Add($"\t\t\tx = {x}");

            procedimiento.Add($"\n\t\t\tLa solución es: x = {x}, y = {y}");

            return (procedimiento, xs);
        }

        public (List<string> steps, List<double> xs) ResolverPorIgualacion(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            List<double> xs = new List<double>();
            var procedimiento = new List<string>();

            procedimiento.Add("\n\t\t\tMétodo de igualación");

            procedimiento.Add("\n\t\t\tResolviendo ambas ecuaciones para x:");
            procedimiento.Add($"\n\t\t\tPrimera ecuación: {FormatEquation(FormatTerm(a1, "x"))}x {FormatSign(b1)} {FormatTerm(Math.Abs(b1), "y")} = {c1}");
            procedimiento.Add($"\t\t\tSegunda ecuación: {FormatEquation(FormatTerm(a2, "x"))}x {FormatSign(b2)} {FormatTerm(Math.Abs(b2), "y")} = {c2}");

            double combined_y = a2 * b1 - a1 * b2;
            double combined_c = a1 * c2 - a2 * c1;
            double y = combined_c / combined_y;
            xs.Add(y);

            double x1 = (c1 - b1 * y) / a1;
            double x2 = (c2 - b2 * y) / a2;

            procedimiento.Add("\n\t\t\tIgualando las dos expresiones de x:");
            procedimiento.Add($"\n\t\t\t({FormatTerm(c1, "")} {FormatSign(b1)} {FormatTerm(Math.Abs(b1), "y")}) / {FormatTerm(a1, "")} = ({FormatTerm(c2, "")} {FormatSign(b2)} {FormatTerm(Math.Abs(b2), "y")}) / {FormatTerm(a2, "")}");
            procedimiento.Add($"\t\t\tMultiplicando ambos lados por {FormatTerm(a1, "")} * {FormatTerm(a2, "")}:");
            procedimiento.Add($"\t\t\t{FormatTerm(a2, "")}({FormatTerm(c1, "")} {FormatSign(b1)} {FormatTerm(Math.Abs(b1), "y")}) = {FormatTerm(a1, "")}({FormatTerm(c2, "")} {FormatSign(b2)} {FormatTerm(Math.Abs(b2), "y")})");
            double num1 = a2 * c1 - a2 * b1 * y;
            double num2 = a1 * c2 - a1 * b2 * y;
            procedimiento.Add($"\t\t\t{FormatTerm(a2 * c1, "")} {FormatSign(a2 * b1)} y = {FormatTerm(a1 * c2, "")} {FormatSign(a1 * b2)} y");

            procedimiento.Add($"\n\t\t\tResolviendo para y:");
            procedimiento.Add($"\n\t\t\ty = ({FormatTerm(a1 * c2, "")} {FormatSign(a2 * c1)}) / ({FormatTerm(a2 * b1, "")} {FormatSign(a1 * b2)})");
            procedimiento.Add($"\t\t\ty = {y}");

            procedimiento.Add("\n\t\t\tSustituyendo el valor de y en una de las ecuaciones para resolver x:");
            double x = (c1 - b1 * y) / a1;
            xs.Add(x);
            procedimiento.Add($"\n\t\t\tx = ({FormatTerm(c1, "")} {FormatSign(b1)} {FormatTerm(Math.Abs(b1), "y")}) / {FormatTerm(a1, "")}");
            procedimiento.Add($"\t\t\tx = {x}");

            procedimiento.Add($"\n\t\t\tLa solución es: x = {x}, y = {y}");

            return (procedimiento, xs);
        }

        static string FormatSign(double value)
        {
            return value >= 0 ? "+" : "-";
        }

        static string FormatEquation(string equation)
        {
            return equation.Replace("=", " = ");
        }

        static string FormatTerm(double coefficient, string variable)
        {
            string formattedCoefficient = coefficient == 1 ? "" : Math.Abs(coefficient).ToString();
            return formattedCoefficient;
        }
        public List<double> Extraction(string equation)
        {
            List<double> coeficients = new List<double>();

            string pattern = @"([+-]?\d*)([a-zA-Z])|([+-]?\d+)";

            MatchCollection matches = Regex.Matches(equation, pattern);

            foreach (Match match in matches)
            {
                if (match.Groups[1].Success && match.Groups[2].Success)
                {
                    string value = match.Groups[1].Value;
                    double coefficient;

                    if (string.IsNullOrEmpty(value) || value == "+" || value == "-")
                    {
                        coefficient = value == "-" ? -1 : 1;
                    }
                    else
                    {
                        coefficient = double.Parse(value);
                    }

                    coeficients.Add(coefficient);
                }
                else if (match.Groups[3].Success)
                {
                    double constant = double.Parse(match.Groups[3].Value);
                    coeficients.Add(constant);
                }
            }

            while (coeficients.Count < 3)
            {
                coeficients.Insert(coeficients.Count - 1, 0);
            }
            coeficients[0] = coeficients[0] * -1;

            return coeficients;
        }

        //    public List<float> ExtractCoeficientsTwo(string equation)
        //    {
        //        List<float> coeficients = new List<float>();

        //        equation = equation.ToLower();
        //        //equation = equation.Replace(" ", "");
        //        equation += "/";
        //        equation = equation.Replace("=", " ");

        //        //MessageBox.Show($"{equation}");

        //        string result = "";

        //        foreach (char part in equation)
        //        {
        //            if (part == '+' || part == '-' || part == '/')
        //            {
        //                result += " " + part;
        //            }
        //            else
        //            {
        //                result += part;
        //            }
        //        }

        //        //MessageBox.Show($"{result}");

        //        string[] parts = result.Split(" ", '/');
        //        string partOne;
        //        string partTwo;
        //        string partThree;

        //        int lenght = parts.Length;
        //        MessageBox.Show($" longitud: {lenght}             {parts[lenght - 1]}");

        //        if (parts.Length >= 3 && parts.Length <= 5 && parts[lenght - 1] == "/")
        //        {
        //            partOne = parts[0];
        //            partTwo = parts[1];
        //            partThree = parts[3];
        //            //MessageBox.Show($"sino");
        //            //MessageBox.Show($" 1:  {partOne} 1: {partTwo} 1: {partThree}");
        //        }
        //        else if (parts.Length >= 6)
        //        {
        //            partOne = parts[0];
        //            partTwo = parts[1];
        //            partThree = parts[4];
        //            //MessageBox.Show($"sino");
        //            //MessageBox.Show($" 1:  {partOne} 1: {partTwo} 1: {partThree}");
        //        }
        //        else
        //        {
        //            partOne = parts[0];
        //            partTwo = parts[1];
        //            partThree = parts[2];
        //            //MessageBox.Show($" 2: {partOne} 1: {partTwo} 1: {partThree}");

        //        }

        //        float a = TravelEquation(partOne);
        //        float b = TravelEquation(partTwo);
        //        float c = TravelEquation(partThree);
        //        a = a * -1;

        //        coeficients.Add(a);
        //        coeficients.Add(c);
        //        coeficients.Add(b);
        //        //MessageBox.Show($" coeficientes identificados en orden: {a}   {b}    {c}");


        //        return coeficients;

        //    }
        //    public float TravelEquation(string part)
        //    {
        //        string aux = "";

        //        for (int i = 0; i < part.Length; i++)
        //        {
        //            if ((part[i] >= 48 && part[i] <= 57) || (part[i] == '+' || part[i] == '-'))
        //            {
        //                aux += part[i];
        //                //MessageBox.Show($" aux  : {aux}");
        //            }
        //            //MessageBox.Show($"no se ejecuta el si, part aqui es: {part[i]}");


        //            //else if (partOne[i] >= 97 && partOne[i] <= 122)
        //            //{
        //            //    x = partOne[i];
        //            //}
        //        }
        //        if (aux == "" || aux == "+" || aux == "-") aux += "1";
        //        float a = float.Parse(aux);

        //        return a;
        //    }

        //    //public void MoveEquation(string equation)
        //    //{
        //    //    List<double> coeficients = ExtractCoeficientsTwo(equation);

        //    //    coeficients[0] = coeficients[0] * -1;
        //    //    string procedimiento = $"{coeficients[0]} {coeficients[0]} / {coeficients[1]}";

        //    //    double y = coeficients[0] + coeficients[2] / 
        //    //}
        //}
    }
}
