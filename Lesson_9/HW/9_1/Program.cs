// Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

void PrintNumbers(int m, int n)
{
    if (m > n)
    return;
    if (m % 2 == 0)
    {
        Console.Write($"{m} ");
    }
    PrintNumbers(m+1,n);
}
PrintNumbers(m,n);