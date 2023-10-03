// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Alex

// double ReadData()
// {
//     return double.Parse(Console.ReadLine() ?? "0");
// }

// bool isTrianglable(double a, double b, double c)
// {
//     return !(a + b <= c || b + c <= a || a + c <= b);
// }

// Console.WriteLine(isTrianglable(ReadData(), ReadData(), ReadData()));


// Вывод сообщения и запись введенных данных
int[] Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";

    return StringToIntArray(value);
}

// Преобразовывает строку в массив чисел
int[] StringToIntArray(string value)
{
    string[] values = value.Split(",");
    int[] triangleSides = new int[values.Length];

    for (int i = 0; i < values.Length; i++)
    {
        triangleSides[i] = Convert.ToInt32(values[i]);
    }
    return triangleSides;
}

// Проверяет, может ли существовать треугольник

bool CheckingTriangle(int[] triangleSides)
{
    return (triangleSides[0]< triangleSides[1]+ triangleSides[2])
            &&(triangleSides[1]< triangleSides[0]+ triangleSides[2])
            &&(triangleSides[2]< triangleSides[0]+ triangleSides[1]);
}

int[] triangleSides= Prompt("Enter sides ',' : ");

Console.Write(CheckingTriangle(triangleSides)? "True": "False");
