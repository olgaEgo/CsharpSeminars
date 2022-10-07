// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Сообщите количество вводимых чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] FillArrayUsersDigits(int size)
{
    double[] array = new double[size];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(double[] array)
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

double[] listOfNumbers = FillArrayUsersDigits(size);
PrintArray(listOfNumbers);

int DigitsOverZero(double[] array)
{
    int count = default;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine($"Количество чисел больше '0' - {DigitsOverZero(listOfNumbers)}");

// int[] FillArrayUsersDigits(int size)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++) //array.Length
//     {
//         System.Console.Write($"Введите {i+1} число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }