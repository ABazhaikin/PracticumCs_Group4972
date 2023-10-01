
double[] genArray(int length, double lowBorder, double maxBorder)
{
    double[] arr = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = random.NextDouble() * (maxBorder - lowBorder) + lowBorder;
    }
    return arr;
}

void printArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

double difference(double[] array)
{
    if (array.Length == 0)
    {
        return 0;
    }
    double min = array[0];
    double max = array[0];
    foreach (double num in array)
    {
        if (num < min)
        {
            min = num;
        }
        if (num > max)
        {
            max = num;
        }
    }
    return max - min;
}

void printResult(string msg)
{
    Console.WriteLine(msg);
}

double[] array = genArray(10, 0.0, 99.0);
printArray(array);
double differenceSum = difference(array);
printResult($"Difference between min and max is {differenceSum}");
