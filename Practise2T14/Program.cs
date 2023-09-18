Console.WriteLine("Enter num: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num % 7 == 0 && num % 23 == 0 ? "true" : "false");