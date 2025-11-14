using Tyuiu.TenkeumiaffoSL.Sprint2.Task0.V13.Lib;

Console.Title = "Спринт #2 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Операции сравнения                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)         *");
Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность*");
Console.WriteLine("* (False, True, False, True, False, True), при x = 1905, y = 475          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 1905;
int y = 475;

Console.WriteLine($"X = {x}");
Console.WriteLine($"Y = {y}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
bool[] result = ds.GetCompareOperations(x, y);

Console.WriteLine("Результат:");
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

Console.ReadLine();