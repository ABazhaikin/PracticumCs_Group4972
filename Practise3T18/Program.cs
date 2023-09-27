//Напишите программуЮ которая прнимает на вход четверь коорндинат.
//И выдает чему равен Х и У, в которой находится эта точка.

// 1) enter x
// 2) enter y
// 3) solving
// 4) showing result


//Вводим данные
// string Prompt(string msg)
// {
//     Console.WriteLine(msg);
//     string values = Console.ReadLine() ?? ",";
//     int quarter = Convert.ToInt32(values);
//     return CheckingCoordinates(quarter);
// }

// // По координатам точки определяем номер четверти
// string CheckingCoordinates(int quarter)
// {
//     switch (quarter)
//     {
//         case 1: return "(x > 0; y > 0)";
//         case 2: return "(x < 0; y > 0)";
//         case 3: return "(x < 0; y < 0)";
//         case 4: return "(x > 0; y < 0)";
//         default: return "out of range";
//     }
// }

// Console.WriteLine(Prompt("Enter quarter : "));

// MAxim

int ReadData()
{
    Console.Write("Eneter q: ");
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

string pointIdent(int quarterNum)
{
    if (quarterNum == 1) return "X > 0, Y > 0";
    if (quarterNum == 2) return "X < 0, Y > 0";
    if (quarterNum == 3) return "X < 0, Y < 0";
    if (quarterNum == 4) return "X > 0, Y < 0";
    return "out of range";
}
int quarterNum = ReadData();
Console.WriteLine(pointIdent(quarterNum));