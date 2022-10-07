// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

Console.Clear();

int[,] myMatrix = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(myMatrix);
Console.WriteLine();
GetSquareOfElementsOnEvenIndexs(myMatrix);
PrintMatrix(myMatrix);

void GetSquareOfElementsOnEvenIndexs(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
                matrix[i, j] *= matrix[i, j];
        }
    }
    // for (int i = 0; i < matrix.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matrix.GetLength(1); j++)
    //     {
    //         if (i % 2 == 0 && j % 2 == 0)
    //         {
    //             matrix[i, j] *= matrix[i, j];
    //         }
    //     }
    // }
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1))
            {
                Console.Write($"{matrix[i, j],4} ");
            }
        }
        Console.WriteLine(" |");
    }
}
