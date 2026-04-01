using System;
using System.Collections.Generic;

namespace ProjectIntegrated2.Model;

internal class ProblemAplication
{
    public List<string> SolveProblemAplication(double tbxThree, double tbxFourth, double tbxFive, double tbxSix)
    {
        List<string> steps = SolveProblem(tbxThree, tbxFourth, tbxFive, tbxSix);

        return steps;
    }

    static List<string> SolveProblem(double Unidades, double CostoOneElement, double CostoSecElement, double TotalCosto)
    {
        List<string> steps = new List<string>();

        steps.Add("\n\n\t\t\tPrimero tenemos en cuenta las dos ecuaciones del sistema: ");
        steps.Add($"\n\t\t\t1) x + y = {Unidades}");
        steps.Add($"\t\t\t2) {CostoOneElement}x + {CostoSecElement}y = {TotalCosto}");

        steps.Add($"\n\t\t\tDespejamos una de las variables:");
        steps.Add($"\n\t\t\tDe 1) x = {Unidades} - y");

        steps.Add($"\n\t\t\tSustituimos x en la ecuación 2):");
        steps.Add($"\n\t\t\t{CostoOneElement}({Unidades} - y) + {CostoSecElement}y = {TotalCosto}");

        steps.Add($"\n\t\t\tResolviendo para y:");
        double y = (TotalCosto - (CostoOneElement * Unidades)) / (CostoSecElement - CostoOneElement);
        steps.Add($"\n\t\t\t y = ( {TotalCosto} - ({CostoOneElement} * {Unidades}) ) / ({CostoSecElement} - {CostoOneElement})");
        steps.Add($"\n\t\t\t y = " + y);

        steps.Add($"\n\t\t\tSustituimos y en la ecuación 1 para encontrar x:");
        double x = Unidades - y;
        steps.Add($"\n\t\t\t x = {Unidades} - {y}");
        steps.Add($"\n\t\t\t x = " + x);

        steps.Add($"\n\t\t\tEl valor de x es: " + x);
        steps.Add($"\n\t\t\tEl valor de y es: " + y);

        return steps;
    }
}
