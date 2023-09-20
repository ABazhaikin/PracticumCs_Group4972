void Variant1()
{
    Console.WriteLine("Enter weeks num:");
    int dayWeek = int.Parse(Console.ReadLine() ?? "0");

    bool weekend = (dayWeek == 6 || dayWeek == 7);

    if (dayWeek >= 1 && dayWeek <= 7)
    {
        if (weekend)
        {
            Console.WriteLine("Yeap");
        }
        else
        {
            Console.WriteLine("Nope");
        }
    }
    else
    {
        Console.WriteLine("Please, enter 1-7.");
    }
}

void Variant2()
{

// Создаем словарь проверяющий цифры дней с названиями

    Dictionary<int, string> week = new Dictionary<int, string>
        {
            {1, "Monday"},
            {2, "Tuesday"},
            {3, "Wednesday"},
            {4, "Thursday"},
            {5, "Friday"},
            {6, "Saturday"},
            {7, "Sunday"}
        };

// Вводим число

    Console.WriteLine("Enter weeks num:");
    int dayWeek = int.Parse(Console.ReadLine() ?? "0");

// Проверяем словарь 

    if (week.ContainsKey(dayWeek))
    {
        string dayName = week[dayWeek];     // Получаем название дня недели по числу
        bool isWeekend = (dayWeek == 6 || dayWeek == 7);    // Проверяем, является ли день недели выходным

// Выводим информацию о дне недели

        if (isWeekend)
        {
            Console.WriteLine($"{dayName} - weekend");
        }
        else
        {
            Console.WriteLine($"{dayName} - not weekend");
        }
    }
    else
    {
        Console.WriteLine("Enter correct num");
    }
}

//Variant1();
Variant2();