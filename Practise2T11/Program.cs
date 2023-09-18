void Variant1()
{

    int randomNumb = new System.Random().Next(100, 1000);
    System.Console.WriteLine(randomNumb);
    char[] digitChar = randomNumb.ToString().ToCharArray();
    System.Console.Write(digitChar[0]);
    System.Console.Write(digitChar[2]);

}

void Variant2()
{

    Console.WriteLine("-1");
    Console.WriteLine("Enter numb");
    string stringNum = Console.ReadLine() ?? "0";
    int num = Convert.ToInt32(stringNum);

    if (num == -1) return;
    if (stringNum.Length != 3)
        Console.WriteLine("not3");
    else
    {
        Console.WriteLine((num / 100) * 10 + (num % 10));
    }
    // Console.WriteLine(stringNum.Length != 3 ? "not 3" : (num / 100) * 10 + (num % 10));
    Console.WriteLine();
}


// Variant1();
Variant2();