﻿// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] oneRowArray2D =  MatrixToOneRowArray(array2D);
PrintArray(oneRowArray2D);
Array.Sort(oneRowArray2D);
PrintArray(oneRowArray2D);
Console.WriteLine();
HowManyNumbersInArray(oneRowArray2D);

void HowManyNumbersInArray (int[] array)
{
    int count = 1;
    int numForCount = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (numForCount == array[i]) count++;
        else
        {
            Console.WriteLine($"{numForCount} -> {count}");
            numForCount = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{numForCount} -> {count}");

}

int[] MatrixToOneRowArray (int[,] matrix)
{
    int[] oneRowArray = new int[matrix.Length];
    int counter = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            oneRowArray[counter] = matrix[i, j];
            counter++;
        }        
    }
    return oneRowArray;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1))
            {
                Console.Write($"{matrix[i, j],4} ");
            }
        }
        Console.WriteLine("");
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
}



// var random = new Random();
// int rows = random.Next(4, 8);
// int columns = random.Next(4, 8);
// int[,] numbers = CreateMatrixRndInt(rows, columns, 1, 9);
// int[] counts = new int[10];

// PrintMatrix(numbers);
// Console.WriteLine();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             counts[numbers[i, j]]++;
//         }
//     }
//     for (int i = 0; i < 10; i++)
//     {
//         Console.WriteLine($"{i} -> {counts[i]}");
//     }


