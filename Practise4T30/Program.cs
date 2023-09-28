// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

// int[] int GenArray(int len)
// {
//     int[] arr = new int[len];

// Random rnd = new Random();
// for (int i = 0; i < len; i++)
// {
//     arr[i]= rnd.Next(0,2);
// }

// return arr;

// }

// void PrintArr(int[] arr)
// {
//      Console.Write("[");
//      for (int i = 0; i < arr.length-1; i++)
//      {
//         Console.Write(arr[i]+",");
//      }
//      Console.WriteLine(arr[arr.length-1]+"]");
// }

// int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// int[] randomArray(int len)

// {
//     int[] rA = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         rA[i] = new Random().Next(0, 2);
//     }
//     return rA;
// }
// void outPutArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ",");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }
// int len = ReadData("Введите длину массива ");
// outPutArray(randomArray(len));

// Анастасия 

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
int[] RandomArray(int count)
{
    int[] randNums = new int[count];
    for (int i = 0; i < randNums.Length; i++)
        randNums[i] = new Random().Next(0, 2);
    return randNums;
}
// Выводит элементы массива в консоль
void OutputArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.Write(array[array.Length - 1] + "]");
}

int count = Prompt("Enter num: ");
// int[] array = new int[count];
int[] array = RandomArray(count);
OutputArray(array);