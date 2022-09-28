// Задача 25: Напишите цикл, который
//1. принимает на вход два числа (A и B) и 
//2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int inputA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int inputB = Convert.ToInt32(Console.ReadLine());

//double numberPow = NumberPow(inputA, inputB);
double numberPow = Math.Round(NumberPow(inputA, inputB), 5, MidpointRounding.ToZero);
Console.WriteLine($"{inputA}, {inputB} -> {numberPow}");

double NumberPow(double numberA, double numberB)
{
    double result = 1;
    double numBB = numberB;
    if (numberB < 0)
    {
        numBB = -numberB;
    }

    for (double pow = 1; pow <= numBB; pow++)
    {
        result *= numberA;
    }

    if (numberB < 0)
    {
        result = 1/result;
    }
    return result;
}


// Console.Write("Введите первое число: ");
// int inputA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int inputB = Convert.ToInt32(Console.ReadLine());

// if (inputB >= 0)
// {
// double numberPow = NumberPow(inputA, inputB);
// Console.WriteLine($"{inputA}, {inputB} -> {numberPow}");
// }
// else
// {
//     int numberPow = NumberPow(inputA, -inputB);
//     Console.WriteLine($"{inputA}, {inputB} -> {1.0 / numberPow}");
// }

// int NumberPow(int numberA, int numberB)
// {
//     int result = 1;
//     for (int pow = 1; pow <= numberB; pow++)
//     {
//         result *= numberA;
//     }
//     return result;
// }
