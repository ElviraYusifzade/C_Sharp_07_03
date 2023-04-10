// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

int summa(int m, int n)
{
    if (m==n)
    return n;
    else return m + summa(m + 1, n);
}

Console.Write($"Сумма натуральных элементов равно {summa(m,n)} ");