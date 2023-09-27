/* Anastasiia
//Напишите программуЮ которая прнимает на входт координаты точки (Х, У), причем Х!=0 и У!=0.
//И выдает номер четверти плоскости, в которой находится эта точка.

// 1) enter x
// 2) enter y
// 3) solving
// 4) showing result


//Вводим данные
int readData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// По координатам точки определяем номер четверти
int QuterTest(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x = readData ("Enter x: ");
int y = readData ("Enter y: ");

int res = QuterTest(x,y);

PrintResult("Point is in " + res );
*/

// Maxim
int ReadData()
{
    Console.Write("Enter num of quarter: ");
    return Convert.ToInt32(Console.ReadLine());
}

string PointIndent(int quarterNum)
{
    if (quarterNum == 1) return "X > 0, Y > 0";
    if (quarterNum == 2) return "X < 0, Y > 0";
    if (quarterNum == 3) return "X < 0, Y < 0";
    if (quarterNum == 4) return "X > 0, Y < 0";
    return " out of range";
}

int quarterNum = ReadData();

Console.WriteLine(PointIndent(quarterNum));
