// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру от 1 до 7 включительно% ");
int number = Convert.ToInt32(Console.ReadLine());

bool Weekend(int num1)
{
    return num1 < 6;
}

bool result = Weekend(number);
if (result) Console.WriteLine($"{number} -> нет");
else Console.Write($"{number} -> да");
