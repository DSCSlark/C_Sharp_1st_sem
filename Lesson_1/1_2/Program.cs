﻿// 2. Напишите программу, которая будет выдавать название дня
// недели по заданному номеру.

Console.WriteLine("Write number of a day: ");

int day = int.Parse(Console.ReadLine()!);

if (day == 1)
{
    Console.WriteLine("Monday");
}
else if (day == 2)
{
    Console.WriteLine("Thuesday");
}
else if (day == 3)
{
    Console.WriteLine("Wednesday");
}
else if (day == 4)
{
    Console.WriteLine("Thursday");
}
else if (day == 5)
{
    Console.WriteLine("Friday");
}
else if (day == 6)
{
    Console.WriteLine("Saturday");
}
else if (day == 7)
{
    Console.WriteLine("Sunday");
}
else
    Console.WriteLine("not a day of week");
    