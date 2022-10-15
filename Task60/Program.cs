// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


var rnd = new Random();
int rows = 4;//rnd.Next(2, 4);
int columns = 3;//rnd.Next(2, 4);
int depth = 2;//rnd.Next(2, 4);

int[] array = new int[90];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    array[i] = 10 + i;
}

int[,,] array3D = CreateArray3DRndInt(10, 99, array);
PrintArray3D(array3D);

int[,,] CreateArray3DRndInt(int min, int max, int[] array)
{
    int[,,] array3d = new int[rows, columns, depth];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int m = rnd.Next(0, length);
                array3d[i, j, k] = array[m];
                (array[m], array[length - 1]) = (array[length - 1], array[m]);
                length--;
            }
        }
    }
    Console.WriteLine("");
    return array3d;
}

void PrintArray3D(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                if (k < array3d.GetLength(2))
                {
                    Console.Write($"{array3d[i, j, k],4} ({i}, {j}, {k}) ");
                }
            }
        }
        Console.WriteLine("");
    }
}
