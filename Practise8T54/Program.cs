// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

void Sort2DArray(int[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numColumns = matrix.GetLength(1);

    for (int i = 0; i < numRows; i++)
    {
        // Используем сортировку пузырьком для текущей строки
        for (int j = 0; j < numColumns - 1; j++)
        {
            for (int k = 0; k < numColumns - j - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}

Console.Clear();
int n = ReadData("Rows: ");
int m = ReadData("Columns: ");
Console.WriteLine("Matrix");
int[,] array2D = Fill2DArray(n, m, 10, 1);
Print2DArray(array2D);
Console.WriteLine("________________");
Sort2DArray(array2D);
Print2DArray(array2D);