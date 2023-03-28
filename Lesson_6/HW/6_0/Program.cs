// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 


Console.Write("Введите количество элементов массива: ");
int m = int.Parse(Console.ReadLine()!);
int[] Array = new int[m];

void mas(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($" {i+1} число: ");
        Array[i] = int.Parse(Console.ReadLine()!);
    }
}

int kol(int[] Array)
{
    int i=0;
    int sum = 0;

    while (i < Array.Length)
    {
        if(Array[i]>0)
        sum = sum + 1;
        i = i + 1;
    }
return sum;
}

mas(m);
Console.Write($"\n Чисел больше нуля: {kol(Array)} ");