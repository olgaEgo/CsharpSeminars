// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8
// 99 -> цифры равны

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");
// int firstDigit = number / 10;
// int secondDigit =  number % 10;
// if (firstDigit == secondDigit) System.Console.WriteLine("Цифры равны");
// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} = {secondDigit}");

// int maxDigit = firstDigit;
// if(secondDigit > firstDigit) maxDigit = secondDigit;
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit =  num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    if (IsEqualDigits(firstDigit, secondDigit)) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

bool IsEqualDigits(int num1, int num2)
{
    return num1 == num2;
}

int number = new Random().Next(10, 100);
int maxDigit = MaxDigit (number);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine($"Наибольшая цифра числа {number} = {result}");


void Zadacha9()
{
    Random random = new Random();
    int number = random.Next(10,100);
    int firstDigit = number / 10;
    int secondDigit =  number % 10;
    // Console.WriteLine(firstDigit);
    // Console.WriteLine(secondDigit);

    if (firstDigit > secondDigit)
{
    Console.WriteLine($"max {number} = {firstDigit}");
}
else
{
    Console.WriteLine($"max = {number} {secondDigit}");
}
}

Zadacha9();