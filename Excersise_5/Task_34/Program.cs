// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве [345, 897, 568, 234] -> 2
Console.Clear();
Console.WriteLine("Программа которая показывает количество чётных чисел в массиве.");
Console.Write ("Задайте длину массива: ");

int N = Convert.ToInt32 (Console.ReadLine ());

void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index]= new Random().Next(100,1000);
        index++;
    }
}

void PrintArray(int [] collection)
{
    int index = 0;
    
    while (index < collection.Length)
    {
        index++;
    }
        Console.WriteLine($"Массив случайных чисел:[{string.Join(", ", collection)}]");
    
}

void parity(int [] collection)
{
    int count = 0;

    for (int index = 0; index < collection.Length; index++)
    {
        if (collection[index]%2==0)
        count++;
    }
        Console.WriteLine($"Количество четных чисел в заданном массиве: {count}");
    
}

int[] massiv1 = new int[N];
FillArray(massiv1);
PrintArray(massiv1);
parity(massiv1);
