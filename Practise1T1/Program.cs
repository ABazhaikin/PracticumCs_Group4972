// Задача №1
// Напишите программу, которая на вход принимает число и
// Выдает его квадрат

Console.WriteLine("Input number");
//Cчитываем данные с консоли
string? inputNum = Console.ReadLine();//??"0";
//Проверяем, чтобы данные были не пустыми   
if (inputNum != null)
{
    // Парсим введенное число 
    // int num = int.Parse(inputNum);
    // Находим квадрат числа
    // int res = num*num;
    // Выводим данные в консоль
    // Console.WriteLine(res); 

}

Console.WriteLine("Num sqr" + (int)Math.Pow(int.Parse(inputNum), 2));
