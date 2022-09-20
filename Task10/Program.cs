// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите целое трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondNumber(int num)
{
    int num1 = num % 100;
    return num1 / 10;
}

int result = SecondNumber(number);
Console.Write($"Вторая цифра числа {number} -> {result}");
