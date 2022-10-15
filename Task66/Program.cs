// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM < 1 && numberN < 1) Console.Write("Введены два ненатуральных числа.");
else
{
    if (numberM > numberN)
{
    (numberM, numberN) = (numberN, numberM);
}

int sum = SumOfNaturalNumbersFromMToN(numberM, numberN);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равна {sum}.");

int SumOfNaturalNumbersFromMToN(int numM, int numN)
{
    int sum = numM;

    if (numN > numM && numM > 0) sum += SumOfNaturalNumbersFromMToN(numM + 1, numN);
    // if (numM > numN && numN > 0) sum += SumOfNaturalNumbersFromMToN(numM - 1, numN);

    if (numN > numM && numM < 0 && numN > 0)
    {
        sum = 0;
        numM = 0;
        sum += SumOfNaturalNumbersFromMToN(numM + 1, numN);
    }

//     if (numM > numN && numN < 0 && numM > 0)
//     {
//         sum = 0;
//         numN = 0;
//         sum += SumOfNaturalNumbersFromMToN(numN + 1, numM);
//     }
     return sum;
}
}

