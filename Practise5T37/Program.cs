// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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



int[] countElement(int[] array)
{
    int[] outArray = new int[array.Length / 2];
    for (int i = 0; i < array.Length/2; i++)

    {
        outArray[i] = array[i] * array[array.Length - 1 - i];
    }

    return outArray;

}

int[] array = genArray(12, 0, 99);
printArray(array);
printArray(countElement(array));

