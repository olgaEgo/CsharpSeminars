// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string quarter = Quarter(x, y);
Console.WriteLine(quarter);

string Quarter(int x, int y)
{
    if (x >0 && y> 0) return "Номер четверти - 1";
    if (x <0 && y> 0) return "Номер четверти - 2";
    if (x <0 && y< 0) return "Номер четверти - 3";
    if (x >0 && y< 0) return "Номер четверти - 4";
    return "Неверные координаы";
}

// int quarter = Quarter(x, y);
// Console.WriteLine(quarter == 0 ? "Введены некорректные координаты" : quarter);

// int Quarter(int x, int y)
// {
//     if (x >0 && y> 0) return 1;
//     if (x <0 && y> 0) return 2;
//     if (x <0 && y< 0) return 3;
//     if (x >0 && y< 0) return 4;
//     return 0;
// }