// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли 
// оно палиндромом (НЕ использовать число как строку, 
// то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /). 14212 -> нет
// 12821 -> да  // 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
CheckPalindrome(number);
 
void CheckPalindrome(int number)
{
    if(number >= 10000)
    {
        int delenie1 = number / 10000;
        int ostatok1 = number % 10;
 
            if(delenie1 == ostatok1)
            {
                number = number / 10;
                int delenie2 = (number / 100) % 10;
                int ostatok2 = number % 10;
                if(delenie2 == ostatok2)
                    Console.WriteLine("Да");
            }
            else 
            Console.WriteLine("Нет");
            
    }
    else
       Console.WriteLine("Некорректное число! ");
}
 
