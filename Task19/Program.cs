// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int input = Convert.ToInt32(Console.ReadLine());

string IsPalindrom(int n)
{
    if ((n % 10 == n / 10000) && ((n % 100) / 10 == (n / 1000) % 10))
    return $"{n} -> да";
    return $"{n} -> нет";
}

string isPalindrom = IsPalindrom(input);
Console.WriteLine(isPalindrom);
