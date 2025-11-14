using Tyuiu.TenkeumiaffoSL.Sprint2.Task1.V6.Lib;

Console.Title = "Спринт #2 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
Console.WriteLine("* которая вернет логическую последовательность:                           *");
Console.WriteLine("* (False, False, True, False, True, False)                                *");
Console.WriteLine("* при a = 915, b = 169, c = 174, d = 133                                  *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int a = 915;
int b = 169;
int c = 174;
int d = 133;

Console.WriteLine($"A = {a}");
Console.WriteLine($"B = {b}");
Console.WriteLine($"C = {c}");
Console.WriteLine($"D = {d}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
bool[] result = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("Результат:");
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

Console.ReadLine();