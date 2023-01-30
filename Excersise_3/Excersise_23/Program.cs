// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N ");
Console.WriteLine("Введите число: ");
if(!int.TryParse(Console.ReadLine(),out int N)||N<=0)
{
    Console.WriteLine("Введено не целое или отрицательное число ");
    return;
}
void powfunc(int N)
{
    int count=1;
    Console.Write(count*count*count);
    count++;

    while(count<=N)
    {
        Console.Write("," + count*count*count);
        count++;
    }
}
powfunc(N);

