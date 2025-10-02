using Tyuiu.TenkeumiaffoSL.Sprint2.Task5.V8.Lib;

Console.Title = "Спринт #2 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
Console.WriteLine("* требуемое значение и возвращает результат.                              *");
Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
Console.WriteLine("* m (порядковый номер месяца) и n (число).                                *");
Console.WriteLine("* По заданным n и m определить дату предыдущего дня                       *");
Console.WriteLine("* (принять, что n и m не характеризуют 1 января).                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите номер месяца (m): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число (n): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string result = ds.FindDateOfPreviousDay(m, n);

Console.WriteLine($"Предыдущий день: {result}");

Console.ReadLine();