Console.WriteLine("Input 1st number");
int input1num = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Input 2nd number");
int input2num = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(input1num == Math.Pow(input2num, 2)? "Yes" : "No");

// <условие>?<вариант1>:<вариант2>

// if (num1 == Math.Pow(input2num, 2))
// {
//     Console.WriteLine("Yes");
// } else {
//     Console.WriteLine("No");
// }


// Второй вариант решения задачи про квадраты чисел

// System.Console.WriteLine("Input 2 numbers");
// int input1num = Convert.ToInt32(Console.ReadLine());
// int input2num = Convert.ToInt32(Console.ReadLine());
// int x = input2num * input2num;

// if (input1num == x)
// {
//     System.Console.WriteLine ("yes");
// } else
// {
//     System.Console.WriteLine("No");
// }


//Третий вариант решения задачи про квадраты чисел 

// Console.WriteLine("Enter 1st");
// int firstNum = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter 2nd");
// int secondNum = int.Parse(Console.ReadLine());

// if (firstNum == Math.Pow(secondNum, 2)){
//     Console.WriteLine("First number is a square of second number");
// }

