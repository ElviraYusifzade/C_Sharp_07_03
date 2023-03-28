// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 


int CountNum()
{
    int count = 0;
    string word;

    while (true)
    {
        Console.Write("Output any number: ");
        word = Console.ReadLine()!;

        if (word == "") return count;
        else if (int.Parse(word) > 0) count += 1;        
    }
}

int count = CountNum();
Console.WriteLine($"Numbers greater than zero: {count}");


// ----------------------------------------2 вариант

int Check(int num)
{
    int count = 0;
    
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine()!);
        if (a > 0) count++;
    }
    return count;
}

Console.Write("Сколько чисел хотели бы ввести?: ");
int a = int.Parse(Console.ReadLine()!);
int result = Check(a);
Console.WriteLine($"Количество чисел больше 0: {result}");