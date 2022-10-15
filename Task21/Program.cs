﻿// Задача 21
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точек: ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int argX1, int argY1, int argZ1, int argX2, int argY2, int argZ2)
{
    double result = Math.Sqrt(Math.Pow((argX2 - argX1), 2) + Math.Pow((argY2 - argY1), 2) + Math.Pow((argZ2 - argZ1), 2));
    return result;
}
// double Distance(double argX1, double argY1, double argZ1, double argX2, double argY2, double argZ2)
// {
//     double result = Math.Sqrt(Math.Pow((argX2 - argX1), 2) + Math.Pow((argY2 - argY1), 2) + Math.Pow((argZ2 - argZ1), 2));
//     return result;
// }
double length = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(length);