using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventOfCode2020.Helpers;
using AdventOfCode2020.Models;

namespace AdventOfCode2020
{
    public class Day2
    {
        public async Task Run() 
        {
            var data = await ReadDataFromFile();

            Console.WriteLine("Start with executing assignment 1!");
            Assignment1(data);
            Console.WriteLine("Finished with executing assignment 1!");
            
            Console.WriteLine("Start with executing assignment 2!");
            //Assignment2(orderedNumbers);
            Console.WriteLine("Finished with executing assignment 2!");            
        }

        private void Assignment1(IList<Day2Input> data) 
        {
            var numberOfValidPasswords = data.Count(x => x.IsValidPassword());
            Console.WriteLine($"There are {numberOfValidPasswords} valid passwords!");
        }

        private async Task<IList<Day2Input>> ReadDataFromFile() 
        {
            var data = new List<Day2Input>();

            var input = await FileContentReader.ReadInput(2);
            foreach(var line in input)
            {
                var blocks = line.Split(' ');
                var numbers = blocks[0].Split('-');
                var minimum = int.Parse(numbers[0]);
                var maximum = int.Parse(numbers[1]);
                var character = blocks[1];
                var password = blocks[2];

                var day2Input = new Day2Input
                {
                    Minimum = minimum,
                    Maximum = maximum,
                    Character = character[0],
                    Password = password
                };

                data.Add(day2Input);
            }

            return data;
        }
    }
}