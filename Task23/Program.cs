// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");

int input = Convert.ToInt32(Console.ReadLine());

void SquareNumTabl(int n)
{
    int counter = 1;
    while (counter <= n)
    {
        Console.WriteLine($"|{counter, 2} | {Math.Pow(counter, 3), 3} |");
        Console.WriteLine(" ---------");
        counter ++;
    }
}

Console.WriteLine(" ---------");
SquareNumTabl(input);