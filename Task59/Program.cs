// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] numberCoordinates = IndexMinInMatrix(array2D);
PrintArray(numberCoordinates);
Console.WriteLine();
int[,] array2Dnew = DeleteRowColumnMin(array2D, numberCoordinates);
DeleteRowColumnMin(array2Dnew, numberCoordinates);
Console.WriteLine();
PrintMatrix(array2Dnew);


int[] IndexMinInMatrix(int[,] matrix)
{
    int[] indexMin = new int[2];
    int minInMatrix = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minInMatrix)
            {
                minInMatrix = matrix[i, j];
                indexMin[0] = i;
                indexMin[1] = j;
            }
        }
    }
    return indexMin;
}

int[,] DeleteRowColumnMin(int[,] matrix, int[] arr)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] newMatrix = new int[rows - 1, columns - 1];
    int numi = 0;
    int numj = 0;
    for (int i = 0; i < rows - 1; i++)
    {
        if (i == arr[0]) numi++;
        numj = 0;
        for (int j = 0; j < columns - 1; j++)
        {
            if (j == arr[1]) numj++;
            newMatrix[i, j] = matrix[i + numi, j + numj];
        }
    }
    return newMatrix;
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
                Console.Write(matrix[i, j] + "\t");
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





// Как написать код, чтобы пользователь 
// мог через пробел сколько угодно чисел написать, 
// чтобы потом с ними что-то делать?

// int[] StringToIntArray(string str)
// {
//     string[] stArr = str.Split(',');
//     int[] array = new int[stArr.Length];
//     for (int i = 0; i < stArr.Length; i++)
//     {
//         array[i] = Convert.ToInt32(stArr[i]);
//     }
//     return array;
// }