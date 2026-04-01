using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectIntegrated2.Model
{
    internal class LinearEquations
    {

        public void FunctionMainSolverSystem2x2(string equationOne, string equationTwo)
        {
            do
            {
                try
                {
                    if (ValidateLinearEquation(equationOne, equationTwo))
                    {
                        MessageBox.Show("Las ecuaciones ingresadas son correctas.", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                    else
                    {
                        MessageBox.Show("Alguna ecuacion no es correcta, ingresa una ecuacion valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Las ecuaciones ingresadas son correctas.", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingresa un formato adecuado para lo que está pidiendo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            while (true);

            SolverMethodEqualization(equationOne, equationTwo);
        }
        public void SolverMethodEqualization(string equationOne, string equationTwo)
        {
            double[] coeficientsEquationOne = PartitionEquationOne(equationOne).coeficientsOne;
            double[] coeficientsEquationTwo = PartitionEquationTwo(equationTwo).coeficientsTwo;

            double determinant = CalculateDeterminant(coeficientsEquationOne, coeficientsEquationTwo, equationOne, equationTwo);

            if (determinant != 0)
            {

            }
            else
            {

            }
        }
        public double CalculateDeterminant(double[] coeficientsEquationOne, double[] coeficientsEquationTwo, string equationOne, string equationTwo)
        {
            return coeficientsEquationOne[0] * coeficientsEquationTwo[1] - coeficientsEquationOne[1] * coeficientsEquationTwo[0];
        }

        public bool ValidateLinearEquation(string equationOne, string equationTwo)
        {
            string pattern = @"^((-?\d+(?:\.\d+)?|-?\d+/\d+|-?[a-z])([a-z])?)([+-])((-?\d+(?:\.\d+)?|-?\d+/\d+|-?[a-z])([a-z])?)=(-?\d+(?:\.\d+)?|-?\d+/\d+|-?\d+)$";

            Regex regex = new Regex(pattern);

            bool validateEquationOne = regex.IsMatch(equationOne);
            bool validateEquationTwo = regex.IsMatch(equationTwo);

            if (!(validateEquationOne && validateEquationTwo))
            {
                return false;
            }

            string isLetter = "";

            for (int i = 0; i < equationOne.Length; i++)
            {
                if (equationOne[i] >= 97 && equationOne[i] <= 122) isLetter += Convert.ToString(equationOne[i]);
            }

            int j = 0;

            for (int i = 0; i < equationTwo.Length; i++)
            {
                if (equationTwo[i] >= 97 && equationTwo[i] <= 122 && equationTwo[i] == isLetter[j]) j++;
            }

            if (j == 2) return true;
            else return false;
        }

        /// <summary>
        /// Separa la primera ecuación en coeficientes y variables para darle un mejor manejo
        /// </summary>
        /// <param name="equationOne">ecuación a evaluar</param>
        /// <returns>retorna una tupla con dos arreglos, uno de tipo double el cuál contiene solo los coeficientes de la ecuación
        /// y el otro es de tipo char el cuál contiene solo las variables de la ecuación</returns>
        public (double[] coeficientsOne, char[] variablesOne) PartitionEquationOne(string equationOne)
        {
            string firtPartNumbersOfEquation = "";
            string secondPartNumbersOfEquation = "";
            string thirdPartNumbersOfEquation = "";
            char firtPartVariableOfEquation = ' ';
            char secondPartVariableOfEquation = ' ';
            char firtPartSignedOfEquation = ' ';
            char secondPartSignedOfEquation = ' ';
            char thirdPartSignedOfEquation = ' ';

            byte posEqual = 0;
            byte posVariableOne = 0;

            string firtNumberOfEquation = "";
            string secondNumberOfEquation = "";
            string thirdNumberOfEquation = "";
            double firtCoeficientEquation = 0;
            double secondCoeficientEquation = 0;
            double thirdCoeficientEquation = 0;

            try
            {
                for (int i = equationOne.Length - 1; i >= 0; i--)
                {
                    if (equationOne[i] == '=') posEqual = Convert.ToByte(i); //valida la posicion en la que se encuentra el igual

                    else if (equationOne[i] >= 48 && equationOne[i] <= 57) //sí encuentra un numero, valida si hace de:
                    {
                        if (i > posEqual) thirdPartNumbersOfEquation += Convert.ToString(equationOne[i]); //tercer coeficiente

                        else if (i < posEqual && i < posVariableOne) firtPartNumbersOfEquation += Convert.ToString(equationOne[i]); //primer coeficiente

                        else secondPartNumbersOfEquation += Convert.ToString(equationOne[i]); //segundo coeficiente
                    }

                    else if (equationOne[i] >= 97 && equationOne[i] <= 122) //sí encuentra una letra (variable)
                    {
                        if (equationOne[i + 1] == '=')
                        {
                            secondPartVariableOfEquation = Convert.ToChar(equationOne[i]); //sí la letra se encuentra justo antes del igual, entonces: es la segunda variable
                        }
                        else //entonces es la primer variable.
                        {
                            firtPartVariableOfEquation = Convert.ToChar(equationOne[i]);
                            posVariableOne = Convert.ToByte(i);  //guarda el valor de la posición de la letra uno, para ser usada mas tarde.
                        }
                        if (i <= posVariableOne && i != 0)
                        {
                            if (equationOne[i - 1] == '-') firtPartNumbersOfEquation += "1"; //valida la primera letra, si la encuentra sola le asigna 1 como coeficiente.
                        }
                        else if (i == 0) firtPartNumbersOfEquation += "1";
                        else if (i < posEqual && i > posVariableOne && (equationOne[i - 1] == '+' || equationOne[i - 1] == '-')) secondPartNumbersOfEquation = "1"; //valida la segunda letra

                    }

                    else if (equationOne[i] == '+' || equationOne[i] == '-') //valida sí encuentra un operador, entonces:
                    {
                        if (i == 0 && i < posVariableOne) //el operador hace parte del primer número.
                        {
                            firtPartSignedOfEquation = Convert.ToChar(equationOne[i]);
                            firtPartNumbersOfEquation += Convert.ToString(equationOne[i]); //guarda el operador donde va ir el número uno.
                        }
                        else if (i > posEqual) // valida sí el iterador se encuentra despues del igual.
                        {
                            thirdPartSignedOfEquation = Convert.ToChar(equationOne[i]);
                            thirdPartNumbersOfEquation += Convert.ToString(equationOne[i]); //guarda el operador donde va ir el número dos.
                        }

                        else if (i != 0) // Valida si el iterador no está al principio de la ecuación
                        { //valida si hay dos signos, si los hay hace la multiplicacion de signos, sino y hay uno solo entonces lo guarda y solo ese.
                            if (equationOne[i - 1] >= 97 && equationOne[i - 1] <= 122 && (equationOne[i + 1] >= 48 || equationOne[i + 1] >= 57))
                            {
                                secondPartSignedOfEquation = Convert.ToChar(equationOne[i]);
                                secondPartNumbersOfEquation += Convert.ToString(equationOne[i]);
                            }
                            else if (equationOne[i] == '+' && equationOne[i - 1] == '+')
                            {
                                secondPartSignedOfEquation = '+';
                                secondPartNumbersOfEquation += secondPartSignedOfEquation;
                            }
                            else if (equationOne[i] == '-' && equationOne[i - 1] == '-')
                            {
                                secondPartSignedOfEquation = '+';
                                secondPartNumbersOfEquation += secondPartSignedOfEquation;
                            }
                            else if (equationOne[i] == '-' && equationOne[i - 1] == '+')
                            {
                                secondPartSignedOfEquation = '-';
                                secondPartNumbersOfEquation += secondPartSignedOfEquation;
                            }
                        }
                    }
                }

                firtNumberOfEquation = new string(firtPartNumbersOfEquation.Reverse().ToArray());
                secondNumberOfEquation = new string(secondPartNumbersOfEquation.Reverse().ToArray());
                thirdNumberOfEquation = new string(thirdPartNumbersOfEquation.Reverse().ToArray());

                firtCoeficientEquation = Convert.ToDouble(firtNumberOfEquation);
                secondCoeficientEquation = Convert.ToDouble(secondNumberOfEquation);
                thirdCoeficientEquation = Convert.ToDouble(thirdNumberOfEquation);
            }
            catch (IndexOutOfRangeException)
            {
                //menus.MessageControlExeption(4);
            }
            catch (FormatException)
            {
                //menus.MessageControlExeption(4);
            }
            double[] coeficientsEquation = { firtCoeficientEquation, secondCoeficientEquation, thirdCoeficientEquation };
            char[] variablesEquations = { firtPartVariableOfEquation, secondPartVariableOfEquation };

            return (coeficientsEquation, variablesEquations);
        }

        /// <summary>
        /// Separa la segunda ecuación en coeficientes y variables para darle un mejor manejo
        /// </summary>
        /// <param name="equationTwo">ecuación a evaluar</param>
        /// <returns>retorna una tupla con dos arreglos, uno de tipo double el cuál contiene solo los coeficientes de la ecuación
        /// y el otro es de tipo char el cuál contiene solo las variables de la ecuación</returns>
        public (double[] coeficientsTwo, char[] variablesTwo) PartitionEquationTwo(string equationTwo)
        {
            string firtPartNumbersOfEquation = "";
            string secondPartNumbersOfEquation = "";
            string thirdPartNumbersOfEquation = "";
            char firtPartVariableOfEquation = ' ';
            char secondPartVariableOfEquation = ' ';
            char firtPartSignedOfEquation = ' ';
            char secondPartSignedOfEquation = ' ';
            char thirdPartSignedOfEquation = ' ';

            byte posEqual = 0;
            byte posVariableOne = 0;

            string firtNumberOfEquation = "";
            string secondNumberOfEquation = "";
            string thirdNumberOfEquation = "";
            double firtCoeficientEquation = 0;
            double secondCoeficientEquation = 0;
            double thirdCoeficientEquation = 0;

            try
            {
                for (int i = equationTwo.Length - 1; i >= 0; i--)
                {
                    if (equationTwo[i] == '=') posEqual = Convert.ToByte(i); //valida la posicion en la que se encuentra el igual

                    else if (equationTwo[i] >= 48 && equationTwo[i] <= 57)
                    {
                        if (i > posEqual) thirdPartNumbersOfEquation += Convert.ToString(equationTwo[i]);

                        else if (i < posEqual && i < posVariableOne) firtPartNumbersOfEquation += Convert.ToString(equationTwo[i]);

                        else secondPartNumbersOfEquation += Convert.ToString(equationTwo[i]);
                    }

                    else if (equationTwo[i] >= 97 && equationTwo[i] <= 122)
                    {
                        if (equationTwo[i + 1] == '=') secondPartVariableOfEquation = Convert.ToChar(equationTwo[i]);

                        else
                        {
                            firtPartVariableOfEquation = Convert.ToChar(equationTwo[i]);
                            posVariableOne = Convert.ToByte(i);
                        }
                        if (i <= posVariableOne && i != 0)
                        {
                            if (equationTwo[i - 1] == '-') firtPartNumbersOfEquation += "1"; //valida la primera letra, si la encuentra sola le asigna 1 como coeficiente.
                        }
                        else if (i == 0) firtPartNumbersOfEquation += "1";
                        else if (i < posEqual && i > posVariableOne && (equationTwo[i - 1] == '+' || equationTwo[i - 1] == '-')) secondPartNumbersOfEquation = "1"; //valida la segunda letra
                    }

                    else if (equationTwo[i] == '+' || equationTwo[i] == '-')
                    {
                        if (i == 0 && i < posVariableOne)
                        {
                            firtPartSignedOfEquation = Convert.ToChar(equationTwo[i]);
                            firtPartNumbersOfEquation += Convert.ToString(equationTwo[i]);
                        }
                        else if (i > posEqual)
                        {
                            thirdPartSignedOfEquation = Convert.ToChar(equationTwo[i]);
                            thirdPartNumbersOfEquation += Convert.ToString(equationTwo[i]);
                        }

                        else if (i != 0)
                        {
                            if (equationTwo[i - 1] >= 97 && equationTwo[i - 1] <= 122 && (equationTwo[i + 1] >= 48 || equationTwo[i + 1] >= 57))
                            {
                                secondPartSignedOfEquation = Convert.ToChar(equationTwo[i]);
                                secondPartNumbersOfEquation += Convert.ToString(equationTwo[i]);
                            }
                            else if (equationTwo[i] == '+' && equationTwo[i - 1] == '+')
                            {
                                secondPartSignedOfEquation = '+';
                                secondPartNumbersOfEquation += secondPartSignedOfEquation;
                            }
                            else if (equationTwo[i] == '-' && equationTwo[i - 1] == '-')
                            {
                                secondPartSignedOfEquation = '+';
                                secondPartNumbersOfEquation += secondPartSignedOfEquation;
                            }
                            else if (equationTwo[i] == '-' && equationTwo[i - 1] == '+')
                            {
                                secondPartSignedOfEquation = '-';
                                secondPartNumbersOfEquation += secondPartSignedOfEquation;
                            }
                        }
                    }
                }

                firtNumberOfEquation = new string(firtPartNumbersOfEquation.Reverse().ToArray());
                secondNumberOfEquation = new string(secondPartNumbersOfEquation.Reverse().ToArray());
                thirdNumberOfEquation = new string(thirdPartNumbersOfEquation.Reverse().ToArray());

                firtCoeficientEquation = Convert.ToDouble(firtNumberOfEquation);
                secondCoeficientEquation = Convert.ToDouble(secondNumberOfEquation);
                thirdCoeficientEquation = Convert.ToDouble(thirdNumberOfEquation);
            }
            catch (IndexOutOfRangeException)
            {
                //menus.MessageControlExeption(4);
            }
            catch (FormatException)
            {
                //menus.MessageControlExeption(4);
            }
            double[] coeficientsEquation = { firtCoeficientEquation, secondCoeficientEquation, thirdCoeficientEquation };
            char[] variablesEquations = { firtPartVariableOfEquation, secondPartVariableOfEquation };

            return (coeficientsEquation, variablesEquations);
        }

        public void FunctionMainSolverFactorize(string equationOne)
        {
            try
            {
                if (ValidateQuadraticEquation(equationOne))
                {
                    MessageBox.Show("Las ecuacion ingresada es correcta.", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ExtractionEquationQuadratic(equationOne);
                }

                else
                {
                    MessageBox.Show("La ecuacion ingresada es incorrecta, ingresa una ecuacion valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Las ecuaciones ingresadas son correctas.", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un formato adecuado para lo que está pidiendo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SolverFactorizeForTrinomialAx(equationOne);
        }

        public void SolverFactorizeForTrinomialAx(string equationOne)
        {
            //ax^2+bx+c=0

            double[] coeficients = ExtractionEquationQuadratic(equationOne).coeficients;
            char[] variables = ExtractionEquationQuadratic(equationOne).variables;

            List<short> dividersAx = new List<short>();
            List<short> dividersC = new List<short>();

            // step one: sacar los divisores de a y c

            for (byte i = 0; i < coeficients.Length; i += 2)
            {
                for (byte j = 1; j <= Math.Abs(coeficients[i]); j++)
                {
                    if (i == 0 && coeficients[i] % j == 0)
                    {
                        dividersAx.Add(j);
                    }
                    else if (i == 2 && coeficients[i] % j == 0)
                    {
                        dividersC.Add(j);
                    }
                }
            }


            int sumPosibility = 0;
            int productPosibility = 0;

            for (byte i = 0; i < dividersC.Count - 1; i++)
            {
                for (byte j = 0; j < dividersC.Count - 1; j++)
                {
                    sumPosibility = dividersC[i] + dividersC[j];
                    productPosibility = dividersC[i] * dividersC[j];

                    if (sumPosibility == coeficients[1] && productPosibility == coeficients[2])
                    {
                        MessageBox.Show($"tus factores son {dividersC[i]} y {dividersC[j]} para un total de: {coeficients[1]}");
                    }
                    else
                    {
                        MessageBox.Show($"no se pudo factorizar");
                    }
                }
            }



            //FUNCIONAR PARA POSIBLE METODO DE FACTORIZACION DE LA FORMA X^2
            //int sumPosibility = 0;
            //int productPosibility = 0;

            //for (byte i = 0; i < dividersC.Count - 1; i++)
            //{
            //    for (byte j = 0; j < dividersC.Count - 1; j++)
            //    {
            //        sumPosibility = dividersC[i] + dividersC[j];
            //        productPosibility = dividersC[i] * dividersC[j];

            //        if (sumPosibility == coeficients[1] && productPosibility == coeficients[2])
            //        {
            //            MessageBox.Show($"tus factores son {dividersC[i]} y {dividersC[j]} para un total de: {coeficients[1]}");
            //        }
            //        else
            //        {
            //            MessageBox.Show($"no se pudo factorizar");
            //        }
            //    }
            //}

            //step Three: 
        }

        bool ValidateQuadraticEquation(string equation)
        {
            string pattern = @"^([-+]?\d*\.?\d*)[a-z]\^2([-+]?\d*\.?\d*)[a-z]([-+]?\d*\.?\d*)=0$";
            //string pattern = @"/ ^([-+] ?\d *\.?\d +)(([a - z])\^2)([-+] ? (\d *\.?\d +|\3))?(\3)(([-+] ?\d *\.?\d +|)?(= 0 ?) ?)?$/";
            return Regex.IsMatch(equation, pattern);
        }

        public (double[] coeficients, char[] variables) ExtractionEquationQuadratic(string equationOne)
        {
            string numberFirtPartEquationPartited = "";
            byte index = 0;

            List<string> listEquationPartited = new List<string>();
            double[] coeficients = new double[3];
            char[] variables = new char[2];

            listEquationPartited = extractEquationQuadraticFirtAndSecondPart(equationOne, index, listEquationPartited);
            index = Convert.ToByte(listEquationPartited.Last());
            index += 2;

            listEquationPartited = extractEquationQuadraticFirtAndSecondPart(equationOne, index, listEquationPartited);
            index = Convert.ToByte(listEquationPartited.Last());

            for (byte i = index; i < equationOne.Length; i++)
            {
                if (equationOne[i] == '-' || equationOne[i] == '+' || equationOne[i] >= 48 && equationOne[i] <= 57 || equationOne[i] == '.')
                {
                    if (equationOne[i] == '+') continue;
                    numberFirtPartEquationPartited += equationOne[i];
                }
                else break;
            }

            listEquationPartited.Add(numberFirtPartEquationPartited);
            listEquationPartited[2] = "";  //elimino los indices que se guardaron para ver el estado de la ultima iteracion.
            listEquationPartited[5] = "";

            try
            {
                coeficients[0] = Convert.ToDouble(listEquationPartited[0]);
                coeficients[1] = Convert.ToDouble(listEquationPartited[3]);
                coeficients[2] = Convert.ToDouble(listEquationPartited[6]);

                variables[0] = Convert.ToChar(listEquationPartited[1]);
                variables[1] = Convert.ToChar(listEquationPartited[4]);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa de nuevo la ecuacion por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ////validar cuando no se ingresa el numero uno.
            //char a1 = equationOne[0];
            //double coeficientsA1 = (a1 >= 97 && a1 <= 122) ? 1 : (a1 == '-') ? -1 : Convert.ToDouble(a1);

            return (coeficients, variables);

            static List<string> extractEquationQuadraticFirtAndSecondPart(string equationOne, byte index, List<string> list)
            {
                string numberFirtPartEquationPartited = "";
                char letterFirtPartEquationPartited = ' ';
                byte aux = 0;

                for (byte i = index; i < equationOne.Length; i++)
                {
                    if (aux != 1 && (equationOne[i] == '-' || equationOne[i] == '+') || equationOne[i] >= 48 && equationOne[i] <= 57 || equationOne[i] == '.')
                    {
                        if (equationOne[i] == '+') continue;
                        numberFirtPartEquationPartited += equationOne[i];
                    }
                    else if (equationOne[i] >= 97 && equationOne[i] <= 122)
                    {
                        letterFirtPartEquationPartited = equationOne[i];
                        aux = 1;
                    }
                    else
                    {
                        index = i;
                        break;
                    }
                }
                list.Add(numberFirtPartEquationPartited);
                list.Add(Convert.ToString(letterFirtPartEquationPartited));
                list.Add(Convert.ToString(index));

                return list;
            }
        }
    }
}
