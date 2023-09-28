int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}

// Считает длинну числа
int digiSum(int number)
{
    int sum = 0;
    while (number != 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}

int number = Prompt("Enter num: ");
Console.WriteLine("sum of "+number+" dig is: "+ digiSum(number));