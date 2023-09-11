int numN;

do{

Console.WriteLine("Enter Num: ");
numN = int.Parse(Console.ReadLine()??"0");

if (numN <= 0)
{
    Console.WriteLine("Chislo dolzhno bit polozhitelnim");
}

} while (numN <= 0);

Console.WriteLine("Chetnie chisla ot 1 do " + numN + " :");

for (int i = 1; i <= numN; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}