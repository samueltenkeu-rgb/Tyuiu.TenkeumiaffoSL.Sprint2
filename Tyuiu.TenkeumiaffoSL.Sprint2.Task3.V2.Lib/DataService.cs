using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task3.V2.Lib
{
    public class DataService : ISprint2Task3V2
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 3)
            {
                // x - 12x + cos(x)
                y = x - 12 * x + Math.Cos(x);
            }
            else if (x == 2)
            {
                // x - (1/x)
                y = x - (1 / x);
            }
            else if (x > -6 && x < 1)
            {
                // x^5 + 10x - 1 / sqrt(x+3)
                if (x + 3 <= 0)
                    throw new ArgumentException("Подкоренное выражение отрицательное.");

                y = Math.Pow(x, 5) + 10 * x - (1 / Math.Sqrt(x + 3));
            }
            else if (x < -6)
            {
                // x + 10x - 1/x^4
                y = x + 10 * x - (1 / Math.Pow(x, 4));
            }
            else
            {
                // x = -6, x = 1, x = 3
                y = 0;
            }

            return Math.Round(y, 3);
        }
    }
}
