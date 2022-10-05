// Задача 29: Напишите программу, которая
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.

int[] arrayNew = new int[8];
GetArray(arrayNew);
PrintArray(arrayNew);

void GetArray(int[] array)
{
    int length = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 1000);
    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

// Отсортированный по модулю
