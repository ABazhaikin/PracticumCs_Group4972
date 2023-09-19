
// {
//     int num1 = int.Parse(Console.ReadLine()??"0");
//     int num2 = int.Parse(Console.ReadLine()??"0");
//     bool test1 = (num1 == num2*num2);
//     bool test2 = (num2 == num1*num1);
//     if (test1) Console.WriteLine("1e  eto kv 2ogo");
//     if (test2) Console.WriteLine("2e  eto kv 1ogo");
//     if(!(test1||test2))
//     {
//         Console.WriteLine("not kv");
//     }

// }

void Variant1()
{
    Console.WriteLine("Enter 1 num:");
    int num1 = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Enter 2 num:");
    int num2 = int.Parse(Console.ReadLine() ?? "0");

    bool test1 = (num1 == num2 * num2);
    bool test2 = (num2 == num1 * num1);

    if (test1)
    {
        Console.WriteLine(" Pervoe chislo kv vtorogo");
    }
    if (test2)
    {
        Console.WriteLine(" Vtoroe chislo kv pervogo");
    }
    if (!(test1 || test2))
    {
        Console.WriteLine("Nikakoe");
    }

}

void Variant2()
{
    int GetNum()
    {
        Console.Write("Enter num: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    int num1 = GetNum();
    int num2 = GetNum();
    
    bool firstPow = num1 == Math.Pow(num2, 2);
    bool secondPow = num2 == Math.Pow(num1, 2);

    Console.WriteLine(firstPow||secondPow ? " odno iz chisel yavlyaetsya kvadratom vtorogo" : "nikakoe chislo ne yavlyaetsya");
}

void Variant3()
{
    Console.WriteLine("Enter 1 num:");
    int num1 = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Enter 2 num:");
    int num2 = int.Parse(Console.ReadLine() ?? "0");

    bool test1 = (num1 == num2*num2);
    bool test2 = (num2 == num1*num1);

    if (test1) Console.WriteLine("Pervoe da vtorogo");
    if (test2) Console.WriteLine("Vtoroe da pervogo");
    if (!(test1||test2))
    {
        Console.WriteLine("NETU");
    }
}

void Variant4()
{
    Console.WriteLine("Enter 1 num:");
    int num1 = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Enter 2 num:");
    int num2 = int.Parse(Console.ReadLine() ?? "0");

    bool test1 = (num1 == num2*num2);
    bool test2 = (num2 == num1*num1);

    if(test1){
        Console.WriteLine("Pervoe kv vtorogo");
    } else if (test2){
        Console.WriteLine("Vtoroe kv pervogo");
    } else{
        Console.WriteLine("NIKAKOE");
    }
}

// Variant1();
// Variant2();
// Variant3();
Variant4();