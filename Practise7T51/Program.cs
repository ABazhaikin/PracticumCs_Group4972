﻿// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Вывод сообщения и запись введённых данных

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
void Random2DArray(int[,] array, int minElement, int maxElement)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minElement, maxElement);
}
// Ищет элементы, у которых оба индекса чётные и меняет их
int MainDiagonalSum(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];

    return sum;
}

// Выводит элементы массива в консоль
void Output2DArray(int[,] array, string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
            Console.Write(array[i, j] + ",\t ");

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }
}

int m = Prompt("Enter m: ");
int n = Prompt("Enter n: ");
int minElement = 0;
int maxElement = 10;

int[,] array = new int[m, n];
Random2DArray(array, minElement, maxElement);
Output2DArray(array, "Array: ");

Console.WriteLine("Summ of main diag is: " + MainDiagonalSum(array));