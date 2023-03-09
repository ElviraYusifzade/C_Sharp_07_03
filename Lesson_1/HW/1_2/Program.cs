// Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.

int max = 0;

Console.WriteLine("Enter the first number");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the second number");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the third number");
int thirdNumber = int.Parse(Console.ReadLine()!);

if(firstNumber > max)
{
    max = firstNumber;
}
if(secondNumber > max)
{
    max = secondNumber;
}
if(thirdNumber > max)
{
    max = thirdNumber;
}

Console.WriteLine("max = " + max);