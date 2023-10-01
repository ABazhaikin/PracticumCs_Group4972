
int[] genArray(int length, int lowBroder, int maxBorder)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(lowBroder, maxBorder + 1);
    }
    return arr;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int sumNegPos(int[] array)
{
    int sum = 0
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void printResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = genArray(10, 0, 99);
printArray(array);
int negativeSumm = sumNegPos(array);
printResult($"{negativeSumm} sum of elements");
