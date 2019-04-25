using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            Calculator cal = new Calculator();
            cal.calc(int.Parse(Console.ReadLine()));
        }
    }
}
