// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите целое число от 1 до 7: ");
string number = Console.ReadLine();
if (number == "1") Console.WriteLine("Monday");
else if (number == "2") Console.WriteLine("Tuesday");
else if (number == "3") Console.WriteLine("Wensday");
else if (number == "4") Console.WriteLine("Thirsday");
else if (number == "5") Console.WriteLine("Friday");
else if (number == "6") Console.WriteLine("Saturday");
else if (number == "7") Console.WriteLine("Sunday");
else Console.WriteLine("Введите верный номер");