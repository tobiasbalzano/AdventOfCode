using System;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose day to run:");
                foreach (var day in Enumerable.Range(1, 24))
                {
                    Console.WriteLine($"Day: {day}");
                }
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Day1.Run();
                        break;
                    case "2":
                        Console.Clear();
                        Day2.Run();
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
