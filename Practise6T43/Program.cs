// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Enter k1, b1, k2 and b2 for 1st and 2nd lines:");
        
        // Считываем значения b1, k1, b2 и k2  
        Console.WriteLine("Enter b1:");
        double b1 = double.Parse(Console.ReadLine()??"0");
        Console.WriteLine("Enter k1:");
        double k1 = double.Parse(Console.ReadLine()??"0");
        Console.WriteLine("Enter b2:");
        double b2 = double.Parse(Console.ReadLine()??"0");
        Console.WriteLine("Enter k2:");
        double k2 = double.Parse(Console.ReadLine()??"0");

        // Находим значение x, при котором прямые пересекаются
        double x = (b2 - b1) / (k1 - k2);

        // Находим значение y для найденного x
        double y = k1 * x + b1;

        Console.WriteLine($"Point is: ({x}, {y})");