// Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] FillSpiralArray(int n)
{
    int[,] spiralArray = new int[n, n];
    int num = 1;
    int startRow = 0, endRow = n - 1, startCol = 0, endCol = n - 1;

    while (num <= n * n)
    {
        for (int i = startCol; i <= endCol; i++)
            spiralArray[startRow, i] = num++;
        startRow++;

        for (int i = startRow; i <= endRow; i++)
            spiralArray[i, endCol] = num++;
        endCol--;

        for (int i = endCol; i >= startCol; i--)
            spiralArray[endRow, i] = num++;
        endRow--;

        for (int i = endRow; i >= startRow; i--)
            spiralArray[i, startCol] = num++;
        startCol++;
    }

    return spiralArray;
}

void PrintArray(int[,] array)
{
    int n = array.GetLength(0);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

int n = 4;
int[,] spiralArray = FillSpiralArray(n);

PrintArray(spiralArray);