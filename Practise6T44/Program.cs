// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Console.Clear();

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintFibonacciNum(int n)
{
    int first = 0;
    int sec = 1;
    int buf = 0;

    for (int i = 0; i < n; i++)
    {
        Console.Write(first + " ");
        buf = first + sec;
        first = sec;
        sec = buf;
    }
}

int n = ReadData("Enter num: ");
PrintFibonacciNum(n);
