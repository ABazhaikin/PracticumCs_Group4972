// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg); // Выводим сообщение пользователю
    int num = Convert.ToInt32(Console.ReadLine() ?? "0"); // Считываем строку и преобразуем её в целое число (если нет - "0")
    return num; // Возвращаем введенное пользователем число
}

int akkerman(int m, int n) //Функция Аккурмана из интернета  "https://blablacode.ru/c_code/1632"
{
    if (m == 0) return n + 1; //если m равно 0, возвращаем n + 1
    else if (n == 0) return akkerman(m - 1, 1); //если n равно 0, вызываем рекурсивно функцию с m - 1 и 1
    else return akkerman(m - 1, akkerman(m, n - 1)); //вызываем функцию и рекурсив akkerman 
}


int m = ReadData("Enter m: "); // Вводим значение m
int n = ReadData("Enter n: "); // Вводим значение n

Console.Write($"Function result is {akkerman(m, n)}"); // Выводим результат выполнения функции Аккермана