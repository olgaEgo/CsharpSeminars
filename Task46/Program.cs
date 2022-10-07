﻿// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
//  1   4   8  19
//  5  -2  33  -2
// 77   3   8   1

//Console.Clear();

System.Console.Write("Введите размер массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arrayMatrix = CreateFillMatrix(m, n, -10, 10);
PrintMatrix(arrayMatrix);

int[,] CreateFillMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write(matrix[i, j] + "\t");
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine();
    }
}
