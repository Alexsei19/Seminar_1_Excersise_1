//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли 
// этот день выходным.
// 6 -> да 7 -> да 1 -> нет
Console.WriteLine("\n\tНеобходимо ввести цифру от 1 до 7 и программа проверит, является ли этот день недели выходным");

Console.WriteLine("Введите цифру от 1 до 7 обозначающую день недели");

int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
    Console.WriteLine("Выходной");

else if (number < 1 || number > 7)
    Console.WriteLine("не является условием ввода");

else
    Console.WriteLine("Рабочий день");
