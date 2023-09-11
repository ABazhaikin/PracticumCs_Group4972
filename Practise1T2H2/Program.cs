Console.WriteLine("ENter 1st number");
int input1num = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Enter 2nd number");
int input2num = int.Parse(Console.ReadLine()??"0");

if (input1num > input2num)
{
    Console.WriteLine("1st max num :" + input1num);
    Console.WriteLine("2nd min num :" + input2num);

} else {
    Console.WriteLine("2nd max num :" + input2num);
    Console.WriteLine("1st min num :" + input1num);
}