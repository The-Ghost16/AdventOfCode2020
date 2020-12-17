using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdventOfCode2020
{
    class Program
    {
        private static readonly IList<IDay> Days = new List<IDay> 
        { 
            new Day1(), 
            new Day2(), 
            new Day3(), 
            new Day4(), 
            new Day5(), 
            new Day6(), 
            new Day7(), 
            new Day8(),
            new Day9(),
            new Day10()
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task.Run(() => RunProgram()).Wait();
        }

        static async Task RunProgram() 
        {
            Console.WriteLine("Welcome to the problem solving solutions of Advent of Code 2020!");

            foreach(var day in Days)
            {
                Console.WriteLine($"Start running the assignments for {day.Title}!");
                await day.Run();
                Console.WriteLine($"Finished all the assignments for {day.Title}!");
                Console.WriteLine($"------------------------------------------------------");
            }

            Console.WriteLine("Finished all the assignments!");
            Console.ReadLine();
        }
    }
}
