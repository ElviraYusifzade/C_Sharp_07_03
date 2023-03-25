// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

Console.Write("количество элементов:");
int count = int.Parse(Console.ReadLine()!);
Console.Write("начало диапозона:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("конец диапозона:");
int b = int.Parse(Console.ReadLine()!);

int[] MakeArray(int c,int m,int n)
{
    int[] array = new int[c];

    for(int i=0; i < array.Length; i++) array[i] = new Random().Next(m, n + 1);
    return array;
}

void PrintArray(int[] arr)
{
    for(int i = 0;i < arr.Length; i ++) Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] array = MakeArray(count, a, b);
PrintArray(array);

bool FindNumber (int[] arr, int n)
{
    for (int i = 0; i < arr.Length; i ++)
    {
        if (arr[i] == n)
        {
            return true;
        }
    }
    return false;
}

Console.Write("Введите число");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(FindNumber(array, n));