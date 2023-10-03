// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// string DecToBin(int num)
// {
//     string line = string.Empty;
//     while (num > 0)
//     {
//         line = num % 2 + line;
//         num = num / 2;
//     }
//     return line;
// }

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}
// Переводит число в двоичное
string DecToBinRec(int number)
{
    return number == 0 ? "" : DecToBin(number / 2) + Convert.ToString(number % 2);
}
// Alexxx
// String bin = Convert.ToString(a, 2);
// String bin = Convert.ToString(int.Parse(Console.ReadLine() ?? "0"), 2);

string DecToBin(int num)
{
    string line = string.Empty;
    while (num > 0)
    {
        line = num % 2 + line;
        num = num / 2;
    }
    return line;
}

int number = Prompt("Enter num: ");

Console.Write($"Bin of num is: {DecToBin(number)}");
Console.WriteLine();
Console.Write($"Rec bin of num is: {DecToBinRec(number)}");
Console.WriteLine();
Console.WriteLine(Convert.ToString(number, 2));
Console.WriteLine(Convert.ToString(number, 8));
Console.WriteLine(Convert.ToString(number, 16));