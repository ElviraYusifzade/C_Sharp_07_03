// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа

int Number = new Random().Next(100, 1000);
int NewNumber = 0;

int NumberWithoutSecDig()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}

NumberWithoutSecDig();

Console.WriteLine();
Console.WriteLine($"Случайное число {Number}, при удалении второй цифры, получится {NewNumber}");
Console.WriteLine();