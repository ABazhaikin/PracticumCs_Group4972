


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



int countEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;

}

static void BubbleSort(int[] array)
{
    int n = array.Length;
    bool swapped;
    do
    {
        swapped = false;
        for (int i = 1; i < n; i++)
        {
            if (array[i - 1] > array[i])
            {
                int temp = array[i - 1];
                array[i - 1] = array[i];
                array[i] = temp;
                swapped = true;
            }
        }
    } while (swapped);
}


void printResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = genArray(12, 99, 999);
printArray(array);
BubbleSort(array);
int evenCount = countEven(array);
printResult($"{evenCount} even elements in array");
printArray(array);