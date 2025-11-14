using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            int prevDay;
            int prevMonth;

            // Если текущий день не первое число месяца
            if (n > 1)
            {
                prevDay = n - 1;
                prevMonth = m;
            }
            else
            {
                // Если первое число месяца, переходим к предыдущему месяцу
                switch (m)
                {
                    case 2: // Февраль → Январь
                        prevDay = 31;
                        prevMonth = 1;
                        break;
                    case 3: // Март → Февраль (28 дней)
                        prevDay = 28;
                        prevMonth = 2;
                        break;
                    case 4: // Апрель → Март
                        prevDay = 31;
                        prevMonth = 3;
                        break;
                    case 5: // Май → Апрель
                        prevDay = 30;
                        prevMonth = 4;
                        break;
                    case 6: // Июнь → Май
                        prevDay = 31;
                        prevMonth = 5;
                        break;
                    case 7: // Июль → Июнь
                        prevDay = 30;
                        prevMonth = 6;
                        break;
                    case 8: // Август → Июль
                        prevDay = 31;
                        prevMonth = 7;
                        break;
                    case 9: // Сентябрь → Август
                        prevDay = 31;
                        prevMonth = 8;
                        break;
                    case 10: // Октябрь → Сентябрь
                        prevDay = 30;
                        prevMonth = 9;
                        break;
                    case 11: // Ноябрь → Октябрь
                        prevDay = 31;
                        prevMonth = 10;
                        break;
                    case 12: // Декабрь → Ноябрь
                        prevDay = 30;
                        prevMonth = 11;
                        break;
                    default: // Январь (но по условию не 1 января)
                        prevDay = 31;
                        prevMonth = 12;
                        break;
                }
            }

            // ИЗМЕНЕНИЕ: форматируем с ведущими нулями
            return $"{prevDay:D2}.{prevMonth:D2}";
        }
    }
}