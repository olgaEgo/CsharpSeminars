// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = CreateMatrixRndInt(1, 9);
PrintMatrix(array1);
Console.WriteLine();
int[,] array2 = CreateMatrixRndInt(1, 9);
PrintMatrix(array2);
Console.WriteLine();
if (array1.GetLength(1) != array2.GetLength(0))
Console.WriteLine($"Матрицу 1 нельзя умножить на матрицу 2");
else
{
    int[,] productMatrix = FillProductMatrix(array1, array2);
    PrintMatrix(productMatrix);
}

int[,] FillProductMatrix(int[,] arr1, int[,] arr2)
{
    int rows1 = array1.GetLength(0);
    int columns1 = array1.GetLength(1);//=n
    int rows2 = array2.GetLength(0);//=n
    int columns2 = array2.GetLength(1);
    int[,] arr3 = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;
            for (int n = 0; n < rows2; n++)
            {
                sum += (arr1[i, n] * arr2[n, j]);
            }
            arr3[i, j] = sum;
        }
    }
    return arr3;
}

int[,] CreateMatrixRndInt(int min, int max)
{
    Random rnd = new Random();
    int rows = rnd.Next(2, 4);
    int columns = rnd.Next(2, 4);
    int[,] matrix = new int[rows, columns];
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
