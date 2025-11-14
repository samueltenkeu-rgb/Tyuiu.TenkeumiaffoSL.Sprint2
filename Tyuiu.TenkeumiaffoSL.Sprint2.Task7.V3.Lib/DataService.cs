using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool insideCircle = (x * x + (y - 1) * (y - 1)) <= 1;

            bool aboveXAxis = y >= 0;

            return insideCircle && aboveXAxis;
        }
    }
}
