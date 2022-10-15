// адача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)  Console.Write("Введите два неотрицательных числа.");
else
{
    int akk = Akkerman(m, n);
    Console.WriteLine(akk);
}

int Akkerman(int m, int n)
{
    int akkerman = 0;
    if (m == 0) akkerman = n + 1;
    if (m > 0 && n == 0) akkerman = Akkerman(m - 1, 1);
    if (m > 0 && n > 0) akkerman = Akkerman(m - 1, Akkerman(m, n - 1));
    return akkerman;
}