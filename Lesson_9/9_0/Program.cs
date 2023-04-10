// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.

Console.Write("Enter the first number: ");
int N = int.Parse(Console.ReadLine()!);

void PrintNums(int n)
{
    if (n == 0) return;
    PrintNums(n - 1);
    Console.Write($"{n} ");
}

Console.Write("Result: ");
PrintNums(N);