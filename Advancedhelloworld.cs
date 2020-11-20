using System;

namespace LearnC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            var day = DateTime.Today;
            Console.WriteLine($"\nHello {name}, on {day:d}, {date:t}!");
            Console.Write("\nPress any key to exit ...");
            Console.WriteLine("Hello World!");
        }
    }
}
