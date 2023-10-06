// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[,] Fill2SumInd(int countRow, int countColumn)
{
    System.Random rnd = new System.Random();
    int[,] array = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i, j] = i + j;

        }
    }

    return array;
}

void print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");

        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            Console.Write(matrix[i, j] + "\t ");
        }
        Console.WriteLine(matrix[i, matrix.GetLength(1) - 1] + "]");
    }
}

int row = ReadData("Enter rows: ");
int columns = ReadData("Enter columns: ");

int[,] arr2D = Fill2SumInd(row, columns);

print2DArray(arr2D);

// Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine() ?? ",";
//     int number = Convert.ToInt32(value);

//     return number;
// }
// // Заполняет массив
// void FillingArray(int[,] array, int m, int n)
// {
//     for (int i = 0; i < m; i++)
//         for (int j = 0; j < n; j++)
//             array[i, j] = i + j;
// }
// // Выводит элементы массива в консоль
// void OutputArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("{");

//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//             Console.Write(array[i, j] + ",\t");

//         Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
//     }
// }

// int m = Prompt("Введите m: ");
// int n = Prompt("Введите n: ");

// int[,] array = new int[m, n];
// FillingArray(array, m, n);
// OutputArray(array);