Console.WriteLine
("Программа, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N");
Console.Write("введите  число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= n)

{
    if (i % 2 == 0)
    {
        Console.Write(i + ",");
    }
    
    i = i + 1;
}

