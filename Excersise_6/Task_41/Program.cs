// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();
Console.WriteLine("Программа считает сколько чисел больше 0 ввёл пользователь ");
Console.Write("Укажите колличество вводимых чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[M];
Console.WriteLine("Введите указанное колличеств чисел через Enter :");
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    Console.Write($"[{String.Join(", ", array)}]");
}

FillArray(massiv);
PrintArray(massiv);

void PositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    Console.WriteLine($"Введено {count} числа больше нуля");
}

Console.WriteLine();
PositiveNumber(massiv);
