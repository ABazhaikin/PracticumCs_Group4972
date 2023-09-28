
int[] rndArray(int len)

{
    int[] rndArr = new int[len];
    for (int i = 0; i < len; i++)
    {
        rndArr[i] = new Random().Next(0, 2);
    }
    return rndArr;
}
void printArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
int len = 8;
printArray(rndArray(len));