void Variant1()
{
// Вводим число
    Console.WriteLine("Enter num:");
    int num = int.Parse(Console.ReadLine() ?? "0");

// Проверяем количество цифр в числе
    if (num >= 100)
    {
        int thirdDig = (num / 100) % 10;    // Получаем третью цифру
        Console.WriteLine("3d dig is: " + thirdDig);
    }
    else
    {
        Console.WriteLine("Less than 3 dig in ur num");
    }
}
Variant1();
