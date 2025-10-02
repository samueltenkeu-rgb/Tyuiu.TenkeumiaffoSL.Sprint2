using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int nextDay = n + 1;
            int nextMonth = m;
            int nextYear = g;

            // Проверяем, не является ли текущий день последним днем месяца
            bool isLastDayOfMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => n == 31,  // Месяцы с 31 днем
                4 or 6 or 9 or 11 => n == 30,                   // Месяцы с 30 днями
                2 => n == 28,                                   // Февраль (не високосный)
                _ => false
            };

            if (isLastDayOfMonth)
            {
                nextDay = 1;
                nextMonth = m + 1;

                // Если декабрь, переходим к следующему году
                if (m == 12)
                {
                    nextMonth = 1;
                    nextYear = g + 1;
                }
            }

            // ИЗМЕНЕНИЕ: форматируем с ведущими нулями для дня и месяца
            return $"{nextDay:D2}.{nextMonth:D2}.{nextYear}";
        }
    }
}