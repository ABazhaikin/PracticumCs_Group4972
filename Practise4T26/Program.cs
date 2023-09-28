// Напишите программу, которая принимает на вход число и выдает количество цифр в числе


// Ivan

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// int numLength(int n)
// {
//     return Convert.ToInt32(Math.Log(n, 10) + 1);
// }

// int n = ReadData("Enter num");
// Console.WriteLine("Length of num " + n + " is : " + numLength(n));

// Anastasiia

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}

// Считает длинну числа
int NumberLength(int number)
{
    int length = 0;
    while (number > 0)
    {
        number /= 10;
        length++;
    }
    return length;
}

int number = Prompt("Введите число: ");
Console.WriteLine(NumberLength(number));