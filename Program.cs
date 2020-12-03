﻿using System;
using System.Threading.Tasks;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task.Run(() => RunProgram()).Wait();
        }

        static async Task RunProgram() 
        {
            Console.WriteLine("Welcome to the problem solving solutions of Advent of Code 2020!");

            Console.WriteLine("We're going to start with day 1!");
            var day1 = new Day1();
            await day1.Run();
            Console.WriteLine("Day 1 is finished!");

            Console.WriteLine("Finished all the assignments!");
            Console.ReadLine();
        }
    }
}
