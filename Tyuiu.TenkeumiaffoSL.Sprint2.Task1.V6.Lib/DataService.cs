using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            // Для получения (False, False, True, False, True, False)

            res[0] = (a < b) | (c < d);      // F | F = False
            res[1] = (a > b) & (c < d);      // T & F = False  
            res[2] = (a > b) || (c < d);     // T || F = True
            res[3] = (a < b) && (c > d);     // F && T = False
            res[4] = (a > b) | (c > d);      // T | T = True
            res[5] = (a < b) ^ (c < d);      // F ^ F = False

            return res;
        }
    }
}