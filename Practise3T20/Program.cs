// Alex L

// double findDistance(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2));
// }

// int x1 = int.Parse(Console.ReadLine() ?? "0");
// int y1 = int.Parse(Console.ReadLine() ?? "0");
// int x2 = int.Parse(Console.ReadLine() ?? "0");
// int y2 = int.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine(findDistance(x1, y1, x2, y2));

// NIkita

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

double Distance(int x, int y)
{
    double distance = Math.Sqrt(x*x+y*y);
    return distance;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x1 = ReadData("Enter x1: ");
int y1 = ReadData("Enter y1: ");
int x2 = ReadData("Enter x2: ");
int y2 = ReadData("Enter y2: ");
double res = Distance ((x2-x1), (y1-y2));
PrintResult("Distance between 2 points is " +$"{res}");