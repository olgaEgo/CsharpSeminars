// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int input = Convert.ToInt32(Console.ReadLine());
string quarter = Quarter(input);
Console.WriteLine(quarter);

string Quarter(int num)
{
    if (num == 1) return "Диапазон: x > 0, y > 0";
    if (num == 2) return "Диапазон: x < 0, y > 0";
    if (num == 3) return "Диапазон: x < 0, y < 0";
    if (num == 4) return "Диапазон: x > 0, y < 0";
    return "Введите верный номер четверти";
}