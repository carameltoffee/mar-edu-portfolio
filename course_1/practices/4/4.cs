using System;
using System.Text;
using System.Xml;

class Program
{
    public class Calculator { 
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subdivide(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Calculate(int num1, int num2, char op)
        {
            switch (op)
            {
                case '+':
                    return Add(num1, num2);
                case '-':
                    return Subdivide(num1, num2);
                case '*':
                    return Multiply(num1, num2);
                case '/':
                    return Divide(num1, num2);
            }
            return 0;
        }
    }
    static void Main()
    {
        var calc = new Calculator();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "exit") { break; }
            string[] split = input.Split(' ');

            Console.WriteLine(calc.Calculate(int.Parse(split[0]), int.Parse(split[2]), char.Parse(split[1])));
        }
    }
}
