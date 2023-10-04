// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Функция для запроса длины массива
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? "0";
    int count = Convert.ToInt32(value);
    return count;
}

// Функция для создания массива, заполненного числами, введенными пользователем
int[] userArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt("input num: ");
    }
    return array;
}

// Функция для подсчета количества положительных чисел в массиве
int CountNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

// Функция для вывода массива на экран
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int length = Prompt("Input array length: ");    // Запрашиваем у пользователя длину массива
int[] array;    //Создаем массив array
array = userArray(length);  // Создаем массив и заполняем его числами, введенными пользователем
printArray(array);  // Выводим массив на экран
Console.WriteLine("Nums count is " + CountNum(array));  // Подсчитываем и выводим колво положительных чисел 
