using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys
{
    public static class Varriables
    {
        public static double EvaluateTheExpression(double a, double b)
        {
            if (a == b)
            {
                throw new Exception("А не должно быть равно В");
            }
            double result;
            result = (5 * a + b * b) / (b - a);
            return result;
        }
        //public static double SwapVars(double a, double b)
        //{

        //}
    }
}
