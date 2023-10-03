// напишите программу, которая перевернет одномерный массив. [1,2,3,4,5]-[5,4,3,2,1]


int[] GenerateRndArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(string msg, int[] array)
{
    Console.Write(msg + "[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[arr.Length - 1 - i] = arr[i];
    }
    return outArr;
}

// void SwapArray(int[] arr)
// {
//     // int bufferElement = 0;
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         (arr[arr.Length - 1 - i],arr[i])=(arr[i],arr[arr.Length - 1 - i]);

//         // bufferElement = arr[arr.Length - 1 - i];
//         // arr[arr.Length - 1 - i] = arr[i];
//         // arr[i]=bufferElement;
//     }
// }

int[] arr = GenerateRndArray(15, 1, 100);
PrintArray("Massive is ", arr);
int[] swapArr = SwapNewArray(arr);
Console.WriteLine("swapped massive is");
PrintArray("", swapArr);

SwapNewArray(arr);
Console.WriteLine("swapped massive is");
PrintArray("", swapArr);