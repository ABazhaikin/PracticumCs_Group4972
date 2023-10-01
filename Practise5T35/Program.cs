//  Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.





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



int countElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)

        if ((array[i] >= 10) && (array[i] <= 99))
        {
            count++;
        }

    return count;

}

void printResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = genArray(123, 0, 999);
printArray(array);
int count = countElement(array);
printResult($"{count} elementov v diapozone ot 10 do 99");
