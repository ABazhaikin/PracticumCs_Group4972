// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.


int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Формирование строки с числами
string SearchForNaturalElementsRec(int m, int n)
{
    return n >= m ? $"{m} " + SearchForNaturalElementsRec(m + 1, n) : "";
}

int m = ReadData("Enter m: ");
int n = ReadData("Enter n: ");

Console.WriteLine((m>n)?SearchForNaturalElementsRec(n, m):SearchForNaturalElementsRec(m,n));

/*
string RecMN(int n, int m)
{
    string res = string.Empty;
    if (n <= m)
    {
        res = n;
    }
    else
    {
        res = m + ", " + RecMN(n, m + 1);
    }
    return res;
}
*/