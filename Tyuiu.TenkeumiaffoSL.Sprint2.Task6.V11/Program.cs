using Tyuiu.TenkeumiaffoSL.Sprint2.Task6.V11.Lib;

Console.Title = "Спринт #2 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Сокращенная форма оператора switch                                *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).                       *");
Console.WriteLine("* По заданным g, n и m определить дату следующего дня.                    *");
Console.WriteLine("* Заданный год не является високосным.                                    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите год (g): ");
int g = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер месяца (m): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число (n): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string result = ds.FindDateOfNextDay(g, m, n);

Console.WriteLine($"Следующий день: {result}");

Console.ReadLine();