Console.WriteLine
("Представлена программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
Console.Write("Введите число a:");
int numbera=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b:");
int numberb=Convert.ToInt32(Console.ReadLine());
if(numbera>numberb) 
{
    Console.Write("Число "+numbera+" большее, число "+numberb+" меньшее.");

}

else if (numbera==numberb)
{
    Console.Write("Число "+numbera+" равняется числу "+numberb+".");
}

else
{
    Console.Write("Число "+numberb+" большее, число "+numbera+ " меньшее.");
}

 