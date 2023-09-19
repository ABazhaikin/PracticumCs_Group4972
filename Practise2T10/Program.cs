void Variant1()
{

    int randomNumb = new System.Random().Next(100, 1000);
    System.Console.WriteLine(randomNumb);
    char[] digitChar = randomNumb.ToString().ToCharArray();
    System.Console.Write(digitChar[1]);

}

void Variant2()
{
    Console.WriteLine("Enter num:");
    string stringNum = Console.ReadLine() ?? "0";
    int num = Convert.ToInt32(stringNum);

    if (stringNum.Length != 3)
        Console.WriteLine("not 3 dig");
    else
    {
        Console.WriteLine((num / 10) % 10);
    }
}

void Variant3()
{
    Console.WriteLine("Enter num:");
    int num = int.Parse(Console.ReadLine());

    if (num >= 100 && num < 1000)
    {
        int secDig = (num / 10) % 10;
        Console.WriteLine("vtoroe chislo: " + secDig);
    }
    else
    {
        Console.WriteLine("not 3 dig");
    }
}


//Variant1();
//Variant2();
Variant3();
