using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // x - горизонталь, y - вертикаль

            switch (y)
            {
                case 2:
                    return x == 4;  // 2=4

                case 3:
                    return x == 4 || (x >= 9 && x <= 12);  // 3=4,9,10,11,12

                case 4:
                    return x == 4 || (x >= 9 && x <= 12);  // 4=4,9,10,11,12

                case 5:
                    return x == 4 || x == 8 || (x >= 9 && x <= 12);  // 5=4,8,9,10,11,12

                case 6:
                    return (x >= 3 && x <= 8) || (x >= 9 && x <= 13);  // 6=3,4,5,6,7,8,9,10,11,12,13

                case 7:
                    return x == 4 || x == 8 || (x >= 9 && x <= 13);  // 7=4,8,9,10,11,12,13

                case 9:
                    return x >= 8 && x <= 12;  // 9=8,9,10,11,12

                case 10:
                    return x >= 6 && x <= 12;  // 10=6,7,8,9,10,11,12

                case 11:
                    return x >= 3 && x <= 8;  // 11=3,4,5,6,7,8

                case 12:
                    return x >= 7 && x <= 9;  // 12=7,8,9

                default:
                    return false; 
            }
        }
    }
}