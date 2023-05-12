using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods;

public class MathShortcuts
{
    public static double Add(double x, double y)
    {
        //Console.WriteLine($"The value of {x} plus {y} is {x+y}.");
        return x + y;
    }

    public static double AddAll(double[] values)
    {
        double result = 0;

        foreach (double value in values)
        {
            result += value;
        }

        //Console.WriteLine($"The total is {result}.");
        return result;
    }
}
