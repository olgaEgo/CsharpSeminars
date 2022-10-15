// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите количество строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[] array = new int[rows * columns];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    array[i] = 1 + i;
}
PrintArray(array);

double[,] array2d = CreateFillArrayWithSpiral(rows, columns, array);
PrintMatrix(array2d);

// double[,] CreateFillArrayWithSpiral(int rows, int columns, int[] arr)
// {
//     double[,] arr2d = new double[rows, columns];
//     int k = 0;
//     int m = 0;
//     int n = 1;
//     while (k < length)
//     {Console.WriteLine(0);
//         for (int i = 0; i == 0; )
//         {Console.WriteLine(1);
//             for (int j = 0; j < columns; j++)
//             {Console.WriteLine(2);
//                 for (j = columns - 1; j == columns - 1; )
//                 {Console.WriteLine(3);
//                     for (i = 1; i < rows - 1; i++)
//                     {Console.WriteLine(4);
//                         for (i = rows; i < rows; )
//                         {Console.WriteLine(5);
//                             for (j = columns-1; j == columns - 1; j--)
//                             {Console.WriteLine(6);
//                                 for (j = 0; j == 0;  )
//                                 {Console.WriteLine(7);
//                                     for (i = rows - 2; i > 0; i--)
//                                     {Console.WriteLine(8);
//                                       arr2d[i, j] = arr[k];
//                                         k++;
//                                         m++;
//                                         n++;
//                                     }

//                                 }
//                             }
//                         }
//                     }
//                 }
//             }
//         }
//     }
//     return arr2d;
// }

double[,] CreateFillArrayWithSpiral(int rows, int columns, int[] arr)
{
    double[,] arr2d = new double[rows, columns];

    for (int k = 0; k < columns;)
    {Console.WriteLine(0);
        for (int i = 0; ;)
        {Console.WriteLine(1);
            for (int j = 0; j < columns; j++)
            {Console.WriteLine(2);
                arr2d[i, j] = arr[k];
            }
                k++;
        }
    }
    return arr2d;
}

void PrintMatrix(double[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write(matrix[i, j] + "\t");
            Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
}