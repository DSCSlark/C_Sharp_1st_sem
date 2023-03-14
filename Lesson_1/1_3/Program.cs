// 3. Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Write number: ");
int a = int.Parse(Console.ReadLine()!);
int b = -a;
while(a >= b)
{
    Console.WriteLine(b);
    b ++;
}