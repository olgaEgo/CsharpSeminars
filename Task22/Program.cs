// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");

int input = Convert.ToInt32(Console.ReadLine());

void SquareNumTabl(int n)
{
    int counter = 1;
    while (counter <= n)
    {
        Console.WriteLine($"|{counter, 3} | {counter * counter, 3} |");
        Console.WriteLine("------------");
        counter ++;
    }
}

SquareNumTabl(input);