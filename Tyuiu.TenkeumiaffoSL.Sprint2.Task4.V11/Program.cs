using Tyuiu.TenkeumiaffoSL.Sprint2.Task4.V11.Lib;

Console.Title = "Спринт #2 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Тернарный оператор                                                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
Console.WriteLine("* использованием тернарного оператора.                                    *");
Console.WriteLine("* Если x - 20*2 < y + 4, то z = (3 + 8/x²)^y                              *");
Console.WriteLine("* иначе z = y - ((x+1)/(y+2))^x                                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите значение X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение Y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.Calculate(x, y);

Console.WriteLine($"Значение Z = {result:F3}");

Console.ReadLine();