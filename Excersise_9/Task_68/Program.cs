// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Даны два неотрицательных числа m и n. Программа вычисляет функцию Аккермана c помощью рекурсии.");

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int ackerman(int m, int n)
{
    if (m == 0)
        return (n + 1);
    else if (n == 0)
        return ackerman(m - 1, 1);
    return ackerman(m - 1, ackerman(m, n - 1));
}

Console.WriteLine(ackerman(m, n));
