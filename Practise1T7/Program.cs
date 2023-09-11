// int numN = int.Parse(Console.ReadLine()??"0");
// if(numN > 100 && numN < 1000)
// {
//     int lastDigit = numN % 10;
//     Console.WriteLine("Последнее цифра числа " + numN + " это : " + lastDigit);
// } else
// { 
//     Console.WriteLine("Число не трехзначное");
// }

// Второй способ решения задачи по выводу последнего числа

// Console.WriteLine ("Input num : ");
// int numN = int.Parse(Console.ReadLine()??"0");
// Console.WriteLine(numN < 1000 && numN > 99 ? numN % 10 : "Число HE трехначное");

Console.WriteLine("Enter num: ");
int numN = int.Parse(Console.ReadLine()??"0");

if (numN > 99 && numN < 1000)
{
    int lastNumN = numN%10;
    Console.WriteLine("Last num " + numN + " its " + lastNumN);
}
else {
    Console.WriteLine("Ne trehzn!");
}