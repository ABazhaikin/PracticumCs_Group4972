void Varinat1()
{
int fisrtNum = int.Parse(Console.ReadLine()??"0");
int secNum = int.Parse(Console.ReadLine()??"0");
Console.WriteLine((fisrtNum%secNum==0)?true:secNum%fisrtNum);
}

void Varinat2()
{
Console.WriteLine("enter 1");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("enter 2");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num2%num1==0?"2 kr 1":"ost ot del: " + (num2%num1));
}

// Varinat1();
Varinat2();