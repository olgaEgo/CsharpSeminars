// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sumOfDigits = DigitSumInNumber(number);
Console.WriteLine(sumOfDigits);

int DigitSumInNumber(int num)  // 21  | 321
{
    int sum = num % 10;
    if (num > 0) sum += DigitSumInNumber(num / 10);
    return sum;
}
