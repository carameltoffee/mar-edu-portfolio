using System;

class Program
{
    static void Main()
    {
        // 1
        int a = 12;
        int b = 5;

        Console.WriteLine($"Сумма: {a + b}");
        Console.WriteLine($"Разность: {a - b}");
        Console.WriteLine($"Произведение: {a * b}");
        Console.WriteLine($"Частное:  {a / b} ");
        Console.WriteLine($"Остаток от деления: {a % b}");



        // 2
        string s = Console.ReadLine();
        Console.WriteLine($"Привет, {s}!");



        // 3
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num * 19);


        // 4
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine(width* height);

        
        // 5
        int cel = int.Parse(Console.ReadLine());
        Console.WriteLine(cel*9/5+32);


        // 6
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        Console.WriteLine($"Среднее арифметическое: {(d+e+f)/3}");

        // 7
        int g = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        Console.WriteLine($"Сумма: {g + h}");
        Console.WriteLine($"Разность: {g - h}");
        Console.WriteLine($"Произведение: {g * h}");
        Console.WriteLine($"Частное:  {g / h} ");


        // 8
        int rub = int.Parse(Console.ReadLine());
        Console.WriteLine($"Dollar : {78.45 * rub}");
        Console.WriteLine($"Euro : {90.23 * rub}");
        Console.WriteLine($"Yuan : {11.03 * rub}");
    }
}

