int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

long SimpleSum(int numA, int numB)
{
    long res = 1;
    while (numB > 0)
    {
        res = res * numA;
        numB= numB-1;
    }
    return res;
}

void PrintResult(string msg, long result)
{
    Console.WriteLine(msg + result);
}


int numberA = ReadData("Enter A: ");
int numberB = ReadData("Enter B: ");
long result = SimpleSum(numberA, numberB);
PrintResult("Result: ", result);
