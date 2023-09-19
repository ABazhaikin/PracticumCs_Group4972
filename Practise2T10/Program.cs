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
        Console.WriteLine((num / 10) % 10 );
    }
    // Console.WriteLine(stringNum.Length != 3 ? "not 3" : (num / 100) * 10 + (num % 10));
}


//Variant1();
Variant2();
