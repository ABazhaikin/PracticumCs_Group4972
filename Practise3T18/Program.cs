//Напишите программуЮ которая прнимает на входт  четверь коорндинат.
//И выдает чему равен Х и У, в которой находится эта точка.

// 1) enter x
// 2) enter y
// 3) solving
// 4) showing result


//Вводим данные
string Prompt(string msg)
{
    Console.WriteLine(msg);
    string values = Console.ReadLine() ?? ",";
    int quarter = Convert.ToInt32(values);
    return CheckingCoordinates(quarter);
}

// По координатам точки определяем номер четверти
string CheckingCoordinates(int quarter)
{
    switch (quarter)
    {
        case 1: return "(x > 0; y > 0)";
        case 2: return "(x < 0; y > 0)";
        case 3: return "(x < 0; y < 0)";
        case 4: return "(x > 0; y < 0)";
        default: return "out of range";
    }
}

Console.WriteLine(Prompt("Enter quarter : "));