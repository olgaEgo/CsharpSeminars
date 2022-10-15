// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
if (IsMatrixSquare(array2D))
{
    int[,] array2DReplaced = ReplaceRowsToColumns(array2D);
    PrintMatrix(array2DReplaced);
}
else Console.WriteLine("Заменить строки на столбцы не возможно.");
Console.WriteLine();
RewriteRowsToColumns(array2D);
PrintMatrix(array2D);

bool IsMatrixSquare(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

void RewriteRowsToColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
        }
    }
}

int[,] ReplaceRowsToColumns(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[,] replaceMatrix = new int[size, size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            replaceMatrix[i, j] = matrix[j, i];
        }
    }
    return replaceMatrix;
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
