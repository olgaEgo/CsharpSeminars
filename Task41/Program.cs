// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Сообщите количество вводимых чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] FillArrayUsersDigits(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++) //array.Length
    {
        System.Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] arr = FillArrayUsersDigits(size);

int DigitsOverZero(int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine($"Количество чисел больше '0' - {DigitsOverZero(arr)}");