using System;

class Program
{
    static void Main()
    {
        // 1
        int a = 12;
        int b = 5;

        Console.WriteLine($"Сумма: {a+b}");
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

    }
}
