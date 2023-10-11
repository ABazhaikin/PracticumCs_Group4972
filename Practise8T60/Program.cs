// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[,,] Fill3DArray(int countRow, int countColumn, int countDeep, int topBorder, int downBorder)
{
    int[,,] array3D = new int[countRow, countColumn, countDeep];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int k = 0; k < countDeep; k++)
            {
                array3D[i, j, k] = new Random().Next(downBorder, topBorder + 1);
            }
        }
    }
    return array3D;
}

void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}


Console.Clear();
int n = ReadData("Rows: ");
int m = ReadData("Columns: ");
int l = ReadData("Deep: ");
Console.WriteLine("Matrix:");
int[,,] array3D = Fill3DArray(n, m, l, 100, 10);
Print3DArray(array3D);