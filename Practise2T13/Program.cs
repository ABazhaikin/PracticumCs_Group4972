void Variant1()
{
    Console.WriteLine("Enter num:");
    int num = int.Parse(Console.ReadLine() ?? "0");

    if (num >= 100)
    {
        int thirdDig = (num / 100) % 10;
        Console.WriteLine("3d dig is: " + thirdDig);
    }
    else
    {
        Console.WriteLine("Less than 3 dig in ur num");
    }
}
Variant1();
