Console.WriteLine("ENter 1st number");
int input1num = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Enter 2nd number");
int input2num = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Enter 3d number");
int input3num = int.Parse(Console.ReadLine()??"0");

if (input1num > input2num && input1num > input3num)
{
    Console.WriteLine("1st max num :" + input1num);

} if (input2num > input1num && input2num > input3num)
{
    Console.WriteLine("2nd max num :" + input2num);

} if (input3num > input1num && input3num > input2num)
{
    Console.WriteLine("3d max num :" + input3num);

}

