// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int ThirdNumber(int num1)
    {
        while (num1 > 999)
        {
            num1 = num1 / 10;
        }
        return num1 % 10;
    }

    int result = ThirdNumber(number);
    Console.Write($"Третья цифра числа {number} -> {result}");
}