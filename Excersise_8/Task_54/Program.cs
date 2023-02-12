// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
Console.WriteLine("Программа, которая упорядочивает по убыванию элементы каждой строки двумерного массива.");

Console.Write("Введите в одной строке через пробел количество строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');   

int n = int.Parse(num[0]);
int m = int.Parse(num[1]);

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-99, 100);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = new int[n, m];

FillMatrix(matrix1);
PrintMatrix(matrix1);

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int x = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = x;
                }
            }
        }
    }
}

int[,] matrix2 = matrix1.Clone() as int[,];
SortMatrix(matrix2);

Console.WriteLine("Массив, упорядоченный в порядке убывания элементов в каждой строке: ");
PrintMatrix(matrix2);