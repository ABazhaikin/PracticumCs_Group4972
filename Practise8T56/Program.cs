//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int ReadData(string msg)
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
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int FindRowWithMinSum(int[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numColumns = matrix.GetLength(1);
    int minSum = int.MaxValue;
    int minRowIndex = -1;

    for (int i = 0; i < numRows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < numColumns; j++)
        {
            rowSum += matrix[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minRowIndex = i;
        }
    }

    return minRowIndex;
}

Console.Clear();
int n = ReadData("Rows: ");
int m = ReadData("Columns: ");
Console.WriteLine("Matrix:");
int[,] array2D = Fill2DArray(n, m, 10, 1);
Print2DArray(array2D);
Console.WriteLine("________________");
int minRowIndex = FindRowWithMinSum(array2D);
Console.WriteLine($"Row with the minimum sum: {minRowIndex}");
