// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

Console.Clear();
Console.WriteLine("Программа, которая задаёт массив из 8 элементов и выводит их на экран.");

int [] array = new int [8];

for (int i=0; i<array.Length;i++)
{
Console.Write ($"Задай элемент №{i+1}:    ");
array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Массив[{string.Join(", ", array)}]");
