// напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int SimpleSum(int numA)
{
    int sumOfNum = 0;
    for (int i = 0; i <= numA; i++)
    {
        sumOfNum = sumOfNum + i;
    }
    return sumOfNum;
}

int GausseSum(int numA)
{
    int sumOfNumber=0;
    sumOfNumber=(numA*(numA+1))/2;
    return sumOfNumber;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numberA = ReadData("Enter A: ");

DateTime d1= DateTime.Now;
int res1 = SimpleSum(numberA);
Console.WriteLine(DateTime.Now-d1);

DateTime d2= DateTime.Now;
int res2 = GausseSum(numberA);
Console.WriteLine(DateTime.Now-d2);

PrintResult("Simple.Sum num from 0 to " + numberA + " is " + res1);
PrintResult("Gausse.Sum num from 0 to " + numberA + " is " + res1);