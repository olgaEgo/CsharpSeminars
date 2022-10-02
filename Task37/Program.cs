// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random(); // var rnd = new Random();

    for (int i = 0; i < size; i++) //array.Length
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1)
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

int[] MultiplicateFirstLastNum (int[] array)
{
    int lenghtNewArray = default;
    if (array.Length % 2 == 0) lenghtNewArray = array.Length / 2;
    else lenghtNewArray = (array.Length / 2) + 1;
    int[] newArray = new int [lenghtNewArray];

    for (int i = 0; i < newArray.Length; i++) // [1, 4, 5, 2, 3]
    {
        newArray[i] = array[i]* array[array.Length - 1 - i];
    }

    if (array.Length % 2 == 1)  newArray[newArray.Length - 1] = array [array.Length / 2];
    return newArray;
}

int[] arr = CreateArrayRndInt(11, 1, 10);
PrintArray(arr);
int[] multiplicateFirstLastNum = MultiplicateFirstLastNum(arr);
PrintArray(multiplicateFirstLastNum);