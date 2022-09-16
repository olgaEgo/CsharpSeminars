// Решаю, как убрать запятую после последнего числа)

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 2;

if (number < 0)
{
    number = - number;
}
while (counter <= number)
{
    if (counter % 2 == 0)
    {
        Console.Write($"{counter}, ");
    }
    counter++;
}
