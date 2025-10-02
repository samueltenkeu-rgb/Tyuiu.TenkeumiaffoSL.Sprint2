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
                y = x - 12 * x + Math.Cos(x);
            }
            else
            {
                if (x == 2)
                {
                    y = x - (1 / x);
                }
                else
                {
                    if (x > -6 && x < 1)
                    {
                        y = Math.Pow(x, 5) + 10 * x - (1 / Math.Sqrt(x + 3));
                    }
                    else
                    {
                        if (x < -6)
                        {
                            y = x + 10 * x - (1 / Math.Pow(x, 4));
                        }
                        else
                        {
               
                            y = 0;
                        }
                    }
                }
            }

            return Math.Round(y, 1);
        }
    }
}