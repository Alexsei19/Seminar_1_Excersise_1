// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Задавая значения M и N программа находит сумму натуральных элементов в промежутке от M до N.");

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Sum(int m, int n)
{
    if (m == n)
        return n;
    return Sum(m, n - 1) + n;
}

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} составляет {Sum(m, n)}");