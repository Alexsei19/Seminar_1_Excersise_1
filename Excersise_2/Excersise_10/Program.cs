//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
//вторую цифру этого числа.

//456 -> 5    //782 -> 8  //918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number >= 1000)

{
    Console.WriteLine("Число не трехзначное, необходимо ввести новое число ");
    return;
}
int number1 = number / 10;
int number2 = number1 % 10;

Console.WriteLine("Вторая цифра введенного числа " + number2);

