// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool CheckNumberInArray(int[] array, int num)
{
    bool result = false;
    for (int i = 0; !result && i < array.Length; i++)
    {
        if (array[i] == num)
        {
            result = true;
        }
    }
    return result;
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
Console.WriteLine("Введите число для проверки его наличия в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
// if (CheckNumberInArray(arr, number)) Console.WriteLine("Да");
// else Console.WriteLine("Нет");
string answer = CheckNumberInArray(arr, number) ? "Да" : "Нет";
Console.WriteLine(answer);