// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine(" Задача которая находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем ");
Console.Write ("Введи b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введи k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введи b2: ");
double b2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write ("Введи k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1==k2)
{
    Console.WriteLine("Прямые параллельны и не пересекаются");
}

else
{
double X = (b2-b1)/(k1-k2);
double Y = k1*X+b1;

Console.WriteLine ($"Точка пересечения имеет координаты ({X}, {Y})");
}
