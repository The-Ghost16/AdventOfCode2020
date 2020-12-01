using System;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to the problem solving solutions of Advent of Code 2020!");

            Console.WriteLine("We're going to start with day 1!");
            var day1 = new Day1();
            day1.Assignment1();

            Console.WriteLine("Finished all the assignments!");
            Console.ReadLine();
        }
    }
}
