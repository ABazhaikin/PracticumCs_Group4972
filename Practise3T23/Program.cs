// // Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

// using System;

// public class Answer
// {
//    static void ShowCube(int N)
//     {
//       // Введите свое решение ниже
//         for (int i = 1; i <= N; i++)
//         {
//             int n = i * i * i;
//             Console.WriteLine($"{n}");
//         }
//     }

//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int N;

//         if (args.Length >= 1) {
//             N = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             N = 6;
//         }

//         // Не удаляйте строки ниже
//         ShowCube(N);
//     }
// }

int topNum = TakeData("Enter num: "); // читаем число из консоли

while (topNum<1) //Проверяем корректность ввода, если нет то сообщаем об этом и просим ввести корректное число
{
    Console.WriteLine("num < 0");
    topNum = TakeData ("Enter num > 0: ");
}

int i=1; // Счетчик для цикла
int cube=0; //куб числа
int numDigitsCube=0; // Кооличество цифр в кубе числа
string firstStr="\u2551 num:     \u2551"; // Первая строка таблицы с границами в виде псевдографики
string secStr="\u2551 Cubes  : \u2551"; // вторая строка таблицы с границами в виде псевдографики

while(i<=topNum){
    cube=(int)Math.Pow(i,3); // Вычисляем куб числа
    numDigitsCube=(int)Math.Log10(cube) + 1; // вычисляем количество цифр в кубе числа через логарифм
    firstStr=firstStr+((i).ToString()).PadRight(numDigitsCube)+"\u2551"; //дополняем первую строку таблицы числом
    secStr=secStr+cube.ToString()+"\u2551";//дополняем вторую строку таблицы значением куба числа и границей ячейки таблицы
    i++;
}
DrawUniLine(firstStr,"\u2554","\u2566", "\u2557");
Console.WriteLine(firstStr);
DrawUniLine(firstStr,"\u2560","\u256C", "\u2563");
Console.WriteLine(secStr);
DrawUniLine(firstStr,"\u255A","\u2569", "\u255D");

int TakeData(string msg) //метод считывающий целое число из консоли, выводя в нее сообщение
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void DrawUniLine(string sampleStr, string startSym, string midSym,string stopSym)
{
    Console.Write(startSym); //рисуем левый верхний угол таблицы
    int i=1;
    while (i<sampleStr.Length-1){
        if(sampleStr[i]=='\u2551') Console.Write(midSym); //если в строке с примером попадается вертикальная линия, то ризсуем
        else Console.Write("\u2550");
        i++;
    }
    Console.WriteLine(stopSym); // рисуем правй верхний угол таблицы
}
