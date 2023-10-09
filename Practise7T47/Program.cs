// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

double [,] Fill2DArray(int countRow, int countColumn, double maxBorder, double lowBorder)
{
    System.Random rnd = new System.Random();
    double [,] array2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            double randomValue = rnd.NextDouble() * (maxBorder - lowBorder) + lowBorder;
            array2D[i, j] = Math.Round(randomValue, 2);
        }
    }

    return array2D;
}

void print2DArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t ");
        }
        Console.WriteLine();
    }
}

int row = ReadData("Enter rows: ");
int columns = ReadData("Enter columns: ");

double[,] arr2D = Fill2DArray(row, columns, 100.0, 10.0);

print2DArray(arr2D);