// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите коэффициент к1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент к2");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
double b2 = double.Parse(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
double y = k1*x +b1;
Console.Write("b1 = " + b1 + ", k1 = " + k1 + ", b2 = " + b2 + ", k2 = " + k2 + " -> (" + x + "; " + y + ")");
