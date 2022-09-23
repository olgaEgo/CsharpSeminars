// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите целое трёхзначное число: ");
int input = Convert.ToInt32(Console.ReadLine());
int num2;

if (input < 100 && input > 999)
{
    Console.WriteLine($"Введите трехзначное число");
}
else
{
num2 = (input % 100 - input % 10) / 10;
Console.Write($"Вторая цифра числа {input} -> {num2}");
}
