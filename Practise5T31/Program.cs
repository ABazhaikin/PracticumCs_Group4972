// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// Заполняем одномерный массив

int[] randomArray(int len, int lowBroder, int maxBorder)
{
    int[] rA = new int[len];
    for (int i = 0; i < len; i++)
    {
        rA[i] = new Random().Next(lowBroder, maxBorder + 1);
    }
    return rA;
}

// Печатаем массив

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

(int, int) negativePositiveSum(int[] arr)
{
    int posSum = 0;
    int negSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)
        {
            posSum=posSum+arr[i];
        }
        else
        {
            negSum=negSum+arr[i];
        }
    }
    return (posSum,negSum);
}

int[] array = randomArray(12, -9, 9);
PrintArr(array);
(int pos,int neg)sum = negativePositiveSum(array);
Console.WriteLine("Summ > 0: " + sum.pos + " Summ < 0: " + sum.neg);