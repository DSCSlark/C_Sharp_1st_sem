// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

Console.WriteLine("Write 1st number: ");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Write 2nd number: ");

int b = int.Parse(Console.ReadLine()!);

if (a == b * b)
{
    Console.WriteLine("yes");
}
else
{
  Console.WriteLine("no");
}