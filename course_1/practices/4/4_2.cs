using System;
using System.Text;
using System.Xml;

class Program
{
    public class Phone
    {
        public string Model;
        public int Battery;

        public Phone(string model, int battery = 100)
        {
            Model = model;
            Battery = battery;
        }

        public void Charge(int amount)
        {
            if (Battery + amount <= 100) { Battery += amount; }
        }

        public void Use(int amount)
        {
            if (Battery - amount >= 0) { Battery -= amount; }
        }
    }
    static void Main()
    {
        var phone = new Phone("Samsung Galaxy");

        phone.Charge(30);
        Console.WriteLine($"Заряд: {phone.Battery}%");

        phone.Use(10);
        Console.WriteLine($"Заряд: {phone.Battery}%");

    }
}
