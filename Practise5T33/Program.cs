// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] genArray(int length, int lowBroder, int maxBorder)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(lowBroder, maxBorder + 1);
    }
    return arr;
}

int prompt(string msg)
{
    Console.WriteLine(msg);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

string check(int[] array, int element)
{
    for (int i = 0; i < array.Length; i++)
    
        if (array[i] == element)
            return $"Yes, index {i+1}";
        return "Nope";
    
}

void outPutArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
        Console.WriteLine(array[array.Length - 1] + "]");
}

int[] array = genArray(12, -9, 9);

outPutArray(array);

int element = prompt("input element: ");

Console.WriteLine(check(array, element));
