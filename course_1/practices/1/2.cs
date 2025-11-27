using System;

class Program
{
    static void Main()
    {

        // 1
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("Число положительное");
        }
        else if (number < 0)
        {
            Console.WriteLine("Число отрицательное");
        }
        else
        {
            Console.WriteLine("Число равно нулю");
        }

        // 2
        Console.Write("Введите возраст: ");
        int age = int.Parse(Console.ReadLine() ?? "0");

        if (age >= 18)
        {
            Console.WriteLine("Вы совершеннолетний");
        }
        else
        {
            Console.WriteLine("Вы несовершеннолетний");
        }

        // 3
        int num = 7;
        if (num % 2 == 0)
        {
            Console.WriteLine("Число чётное");
        }
        else
        {
            Console.WriteLine("Число нечётное");
        }

        // 4
        int a = 5, b = -2;

        if (a > 0 && b > 0)
        {
            Console.WriteLine("Оба числа положительные");
        }

        if (a > 0 || b > 0)
        {
            Console.WriteLine("Хотя бы одно число положительное");
        }

        if (!(a > 0))
        {
            Console.WriteLine("a не положительное");
        }

        // 5
        Console.Write("Введите оценку (grade): ");
        int grade = int.Parse(Console.ReadLine() ?? "0");

        if (grade < 3)
        {
            Console.WriteLine("Неудовлетворительно");
        }
        else if (grade == 3)
        {
            Console.WriteLine("Удовлетворительно");
        }
        else if (grade == 4)
        {
            Console.WriteLine("Хорошо");
        }
        else if (grade == 5)
        {
            Console.WriteLine("Отлично");
        }
        else
        {
            Console.WriteLine("Оценка вне диапазона 1–5");
        }


        // 6
        int n1 = int.Parse(Console.ReadLine() ?? "0");
        int n2 = int.Parse(Console.ReadLine() ?? "0");
        int n3 = int.Parse(Console.ReadLine() ?? "0");
        int max3 = n1;
        if (n2 > max3) max3 = n2;
        if (n3 > max3) max3 = n3;
        Console.WriteLine("Наибольшее: " + max3);


        // 7
        Console.Write("Введите первое число: ");
        double c1 = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введите второе число: ");
        double c2 = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введите операцию (+, -, *, /): ");
        string op = Console.ReadLine() ?? "+";

        if (op == "+")
        {
            Console.WriteLine("Результат: " + (c1 + c2));
        }
        else if (op == "-")
        {
            Console.WriteLine("Результат: " + (c1 - c2));
        }
        else if (op == "*")
        {
            Console.WriteLine("Результат: " + (c1 * c2));
        }
        else if (op == "/")
        {
            if (c2 != 0)
                Console.WriteLine("Результат: " + (c1 / c2));
            else
                Console.WriteLine("Деление на ноль невозможно");
        }
        else
        {
            Console.WriteLine("Неизвестная операция");
        }
    }
}
