// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2) Console.WriteLine($"Прямые совпадают между собой.");
else if (k1 == k2)
{
    Console.WriteLine($"Прямые параллельны между собой.");
}
else
{
    double[] coordinates = CoordinatesOfIntersectionOfStraightLines(b1, k1, b2, k2);
    PrintArray(coordinates);
}

double[] CoordinatesOfIntersectionOfStraightLines(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b1 - b2) / (k2 - k1), 1);
    double y = Math.Round(k1 * x + b1, 1);
    double[] array = new double[] { x, y };
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
}