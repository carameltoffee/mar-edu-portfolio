using System;

class Program
{
    static int counter = 0;

    static void Main()
    {
        Console.WriteLine("=== Задание 1 ===");
        SayHello();
        SayHello();
        SayHello();

        Console.WriteLine("\n=== Задание 2 ===");
        Greet("Саша");
        Greet("Ярослав");
        Greet("Анна");

        Console.WriteLine("\n=== Задание 3 ===");
        PrintPerson("Егор", 15, "Москва");
        PrintPerson("Мария", 25, "Санкт-Петербург");

        Console.WriteLine("\n=== Задание 4 ===");
        PrintPerson("Иван", 20, "Футбол");
        PrintPerson("Ольга");
        PrintPerson("Петр", 30);

        Console.WriteLine("\n=== Задание 5 ===");
        int number = 5;
        int result = Square(number);
        Console.WriteLine($"Квадрат числа {number} = {result}");

        Console.WriteLine("\n=== Задание 6 ===");
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите операцию (+, -, *, /):");
        char operation = Convert.ToChar(Console.ReadLine());

        double calcResult = 0;
        bool operationValid = true;

        switch (operation)
        {
            case '+':
                calcResult = Add(num1, num2);
                break;
            case '-':
                calcResult = Subtract(num1, num2);
                break;
            case '*':
                calcResult = Multiply(num1, num2);
                break;
            case '/':
                if (num2 != 0)
                {
                    calcResult = Divide(num1, num2);
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    operationValid = false;
                }
                break;
            default:
                Console.WriteLine("Неизвестная операция!");
                operationValid = false;
                break;
        }

        if (operationValid)
        {
            Console.WriteLine($"Результат: {calcResult}");
        }

        Console.WriteLine("\n=== Задание 7 ===");
        Console.WriteLine($"counter до вызовов: {counter}");
        Increment();
        Console.WriteLine($"counter после первого вызова: {counter}");
        Increment();
        Console.WriteLine($"counter после второго вызова: {counter}");
        Increment();
        Console.WriteLine($"counter после третьего вызова: {counter}");

        Console.WriteLine("\n=== Задание 8 ===");
        Console.WriteLine($"Multiply(2, 3) = {Multiply(2, 3)}");
        Console.WriteLine($"Multiply(2, 3, 4) = {Multiply(2, 3, 4)}");
        Console.WriteLine($"Multiply(2.5, 4.0) = {Multiply(2.5, 4.0)}");
    }

    static void SayHello()
    {
        Console.WriteLine("Привет, мир!");
    }

    static void Greet(string name)
    {
        Console.WriteLine($"Привет, {name}!");
    }

    static void PrintPerson(string name, int age, string city)
    {
        Console.WriteLine($"Имя: {name} Возраст: {age} Город: {city}");
    }

    static void PrintPerson(string name, int age = 18, string hobby = "Не указано")
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Хобби: {hobby}");
    }

    static int Square(int x)
    {
        return x * x;
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }

    static void Increment()
    {
        counter++;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }
}
