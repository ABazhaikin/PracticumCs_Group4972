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

    Console.WriteLine("Enter weeks num:");
    int dayWeek = int.Parse(Console.ReadLine() ?? "0");

    if (week.ContainsKey(dayWeek))
    {
        string dayName = week[dayWeek];
        bool isWeekend = (dayWeek == 6 || dayWeek == 7);

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