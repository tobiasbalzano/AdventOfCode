using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AdventOfCode
{
    public abstract class Day
    {
        public static Stopwatch Stopwatch;
        public static void Run(int day, Action action)
        {
            Console.WriteLine($"Day {day}:");
            Stopwatch = new Stopwatch();
            Stopwatch.Start();
            action.Invoke();
            Stopwatch.Stop();
            Console.WriteLine($"Elasped seconds: {Stopwatch.Elapsed.TotalSeconds}, milliseconds: {Stopwatch.ElapsedMilliseconds}, ticks: {Stopwatch.ElapsedTicks}");
        }
    }
}
