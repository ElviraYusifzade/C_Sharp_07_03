// Напишите программу замена элементов массива:
// положительные элементы  замените на соответствующие отрицательные, и наоборот.

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
}

void MyFunc(int[]arr)
{
    for(int i = 0; i < arr.Length; i ++)
    {
        arr[i]*=-1;
    }
}

int [] array = MakeArray(count, a, b);
PrintArray(array);
Console.WriteLine();
MyFunc(array);
PrintArray(array);