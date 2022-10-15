// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2D = CreateFillMatrix(3, 3, 1, 9);
PrintMatrix(array2D);
Console.Write($"Суммы строк:");
int[] arrayOfSums = FindSumOfNumbersInRows(array2D);
PrintArray(arrayOfSums);
Console.WriteLine();
int minSumRow = FindIndexOfRowWithMinSumOfNumbers(arrayOfSums);
Console.Write($"Номер строки с наименьшей суммой - {minSumRow + 1}");
Console.WriteLine();

int[] FindSumOfNumbersInRows(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        result[i] = sum;
    }
    return result;
}

int FindIndexOfRowWithMinSumOfNumbers(int[] array)
{
    int length = array.Length;
    int index = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] < array[index]) index = i;
    }
    return index;
}

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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write(matrix[i, j] + "\t");
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] array)
{
    Console.Write(" ");
    int length = array.Length;
    for (int i = 0; i < length; i++)
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
    Console.WriteLine();
}
