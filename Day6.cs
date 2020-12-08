using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventOfCode2020.Helpers;
using AdventOfCode2020.Models;

namespace AdventOfCode2020
{
    public class Day6 : Day<IList<Day6Input>>
    {
        public override string Title => "Day 6";

        protected override void Assignment1()
        {
            var sum = data.Sum(x => x.AnyAnsweredQuestions);
            Console.WriteLine($"The sum is: {sum}");
        }

        protected override void Assignment2()
        {
            var sum = data.Sum(x => x.AllAnsweredQuestions);
            Console.WriteLine($"The sum is: {sum}");
        }

        protected override async Task<IList<Day6Input>> ReadData()
        {
            var content = new List<Day6Input>();
            var input = await FileContentReader.ReadInput(6);

            var day6Input = new Day6Input();
            foreach(var line in input)
            {
                if(string.IsNullOrEmpty(line))
                {
                    content.Add(day6Input);
                    day6Input = new Day6Input();
                    continue;
                }

                day6Input.Answers.Add(line);
            }
            content.Add(day6Input);

            return content;
        }
    }
}