﻿// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → [] */

string text = "(Hello, 2, world, :-)";
Console.WriteLine("Первоначальный массив:  " + "[" + text + "]");
string[] sign = text.Split(' ');
int count = 0;
Console.Write("Сформирован новый массив: " + "[");
foreach (var sub in sign)
{
    if (sub.Length <= 3)
    {
        {
            Console.Write(sub);
            count++;
        }
    }
}
Console.Write("]");
Console.WriteLine();
Console.WriteLine("Количество найденных строк, длина которых меньше, либо равна трем символам: " + count);