Console.WriteLine("Enter num: ");
int numN = int.Parse(Console.ReadLine()??"0");

if (numN % 2 == 0)
{
    
    Console.WriteLine("chislo " + numN + " yavlyaetsya chetnim" );
}
else {
    Console.WriteLine("chislo " + numN + " ne yavlyaetsya chetnim" );
}