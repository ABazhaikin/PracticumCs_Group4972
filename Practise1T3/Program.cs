// Первый вариант решения задачи про недели

// Console.WriteLine("Input day number.(1-7): ");
// int day = int.Parse(Console.ReadLine() ?? "0");

// string[] dayOfWeek = new string[7];

// dayOfWeek[0] = "Monday";
// dayOfWeek[1] = "Tuesday";
// dayOfWeek[2] = "Wendsday";
// dayOfWeek[3] = "THursday";
// dayOfWeek[4] = "Friday";
// dayOfWeek[5] = "Saturday";
// dayOfWeek[6] = "Sunday";

// Console.WriteLine(dayOfWeek[day - 1]);


// Второй вариант по выбору дня недели по числу

// Console.WriteLine("Input number");
// int a = Convert.ToInt32(Console.ReadLine());

// switch(a)
// {
//     case 1: Console.WriteLine("Monday");
//     break;

//     case 2: Console.WriteLine("Tuesday");
//     break;

//     case 3: Console.WriteLine("Wednesday");
//     break;

//     case 4: Console.WriteLine("Thursday");
//     break;

//     case 5: Console.WriteLine("Friday");
//     break;

//     case 6: Console.WriteLine("Saturday");
//     break;

//     case 7: Console.WriteLine("Sunday");
//     break;

// }


// Третий способ решения задачи с неделями


// string day = Console.ReadLine()?? "0";

// switch (day)

// {
//     case "1": Console.WriteLine("Monday"); break;
//     case "2": Console.WriteLine("Tuesday"); break;
//     case "3": Console.WriteLine("Wednesday"); break;
//     case "4": Console.WriteLine("Thursday"); break;
//     case "5": Console.WriteLine("Friday"); break;
//     case "6": Console.WriteLine("Saturday"); break;
//     case "7": Console.WriteLine("Sunday"); break;
//     default: Console.WriteLine("Wrong num"); break;
// }


// Четвертый способ решения задачи

// Console.WriteLine("Enter day number");
// int dayNum = int.Parse(Console.ReadLine());

// if(dayNum == 1){
//     Console.WriteLine("Monday");
// }
// else if (dayNum==2){
//     Console.WriteLine("Tuesday");
// }
// else if (dayNum==3){
//     Console.WriteLine("Wednesday");
// }
// else if (dayNum==4){
//     Console.WriteLine("Thursday");
// }
// else if (dayNum==5){
//     Console.WriteLine("Friday");
// }
// else if (dayNum==6){
//     Console.WriteLine("Saturday");
// }
// else if (dayNum==7){
//     Console.WriteLine("Sunday");
// }
// else{
//     Console.WriteLine("Not day of week");
// }


// Blyaaaaaaa ya hz

// Console.WriteLine("Enter day number");
// int dayNum = int.Parse(Console.ReadLine());

// string outDayofWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum - 1));
// enum DayOfWeek
// {
//     Понедельник,
//     Вторник,
//     Среда,
//     Четверг,
//     Пятница,
//     Суббота,
//     Воскресенье
// }

// Console.WriteLine(outDayofWeek);

