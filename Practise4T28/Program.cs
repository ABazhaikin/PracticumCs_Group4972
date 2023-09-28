// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

// Alex

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// long CountFact(int num)
// {
//     long fact = 1;
//     for (int i = 2; i <= num; i++)
//     {
//         fact *= i;
//     }
//     return fact;
// }

// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// int num = ReadData("Enter num: ");
// long fact = CountFact(num);

// PrintResult("Factorial of " + num + " is " + fact);



int readData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


void PrintResult(string mes)
{
    Console.WriteLine(mes);
}


long FactorialNum(int num)
{
    long fact = 1;

    for (int i = 2; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}

int enterNum = readData("Введите число: ");
long result = FactorialNum(enterNum);

PrintResult($"Произведение чисел от 1 до {enterNum} = {result}");