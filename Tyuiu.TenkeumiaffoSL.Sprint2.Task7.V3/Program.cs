using Tyuiu.TenkeumiaffoSL.Sprint2.Task7.V3.Lib;

Console.Title = "Спринт #2 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Проверка попадания точки в заштрихованную область                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Определить, находится ли точка в нижней части окружности                *");
Console.WriteLine("* x² + (y - 1)² = 1, ограниченной снизу осью OX.                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
bool result = ds.CheckDotInShadedArea(x, y);

if (result)
{
    Console.WriteLine($"Точка ({x},{y}) находится в заштрихованной области.");
}
else
{
    Console.WriteLine($"Точка ({x},{y}) не находится в заштрихованной области.");
}

Console.ReadLine();
