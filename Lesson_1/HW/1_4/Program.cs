// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter the number");

int number = int.Parse(Console.ReadLine()!);

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.WriteLine(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}