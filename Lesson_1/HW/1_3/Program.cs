// Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два, без остатка).

Console.WriteLine("Enter the number");

int number = int.Parse(Console.ReadLine()!);

int remDiv = number % 2;

if(remDiv == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}