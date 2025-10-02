using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task0.V13.Lib
{
    public class DataService : ISprint2Task0V13
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y;      // 1905 == 475 → False
            res[1] = x != y;      // 1905 != 475 → True
            res[2] = x < y;       // 1905 < 475 → False
            res[3] = x > y;       // 1905 > 475 → True
            res[4] = x <= y;      // 1905 <= 475 → False
            res[5] = x >= y;      // 1905 >= 475 → True

            return res;
        }
    }
}