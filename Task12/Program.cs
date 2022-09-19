// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int num1, int num2)
{
    return num1 % num2 == 0;
}

bool result = Multiplicity(number1, number2);

if (result) Console.WriteLine($"{number1} кратно {number2}");
else Console.Write($"{number1} не кратно {number2}! Остаток: {number1 % number2}");

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите первое число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int rest = number1 % number2;
// if (rest == 0) Console.WriteLine($"{number1}, {number2} -> кратно");
// else Console.WriteLine($"{number1}, {number2} -> не кратно, остаток {rest}");

