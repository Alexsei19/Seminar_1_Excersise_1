Console.WriteLine
("Программа, которая на вход принимает число и выдаёт, является ли число чётным");
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2==0)

{
    Console.Write(number+" - число четное");
}

else 

{
Console.Write(number+" - число не четное");
}

