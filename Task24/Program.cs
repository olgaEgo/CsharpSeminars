//Задача 24: Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2. выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());
int sumResult = SumNumbers(input);
Console.WriteLine($"Сумма чисел о 1 до {input} = {sumResult}");

int SumNumbers(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}