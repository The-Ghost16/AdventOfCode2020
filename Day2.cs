using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.Models;

namespace AdventOfCode2020
{
    public class Day2 : Day<IList<Day2Input>>
    {
        public Day2() : base(2)
        {            
        }

        protected override void Assignment1() 
        {
            var numberOfValidPasswords = data.Count(x => x.IsValidPassword());
            Console.WriteLine($"There are {numberOfValidPasswords} valid passwords!");
        }

        protected override void Assignment2()
        {
            var numberOfValidPasswords = data.Count(x => x.IsValidPositionedPassword());
            Console.WriteLine($"There are {numberOfValidPasswords} valid passwords with correct character positioning!");
        }

        protected override IList<Day2Input> ConvertInput(IList<string> input) 
        {
            var data = new List<Day2Input>();

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