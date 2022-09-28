// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());

int quantity = QuantityOfDigits(Math.Abs(input));
int sum = SumOfDigits(input, quantity);

Console.WriteLine($"{input} -> {SumOfDigits(input, quantity)}");

int QuantityOfDigits(int number)
{
    int quantityOfDigits = 0;
    for (; quantityOfDigits < number; quantityOfDigits++)
    {
        number = number / 10;
    }
    return quantityOfDigits;
}

int SumOfDigits(int number, int quantityOfDigits)
{
    int sumOfDigits = 0;
    for (int i = 0; i <= quantityOfDigits; i++)
    {
        sumOfDigits += number % 10;
        number /= 10;
    }
    return sumOfDigits;
}
