using Tyuiu.TenkeumiaffoSL.Sprint2.Task3.V2.Lib;

Console.Title = "Спринт #2 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Вложенные операторы if-else                                       *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Вычислить значение функции Y по кусочной формуле.                       *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите значение X: ");
double x = Convert.ToDouble(Console.ReadLine());

DataService ds = new DataService();
double result = ds.Calculate(x);

Console.WriteLine("***************************************************************************");
Console.WriteLine($"Значение функции Y = {result:F3}");
Console.WriteLine("***************************************************************************");

Console.ReadLine();
