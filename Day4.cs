using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.Models;

namespace AdventOfCode2020
{
    public class Day4 : Day<IList<Day4Input>>
    {
        public Day4() : base(4)
        {            
        }

        protected override void Assignment1()
        {
            var validPassportCount = data.Count(x => x.IsValidPassport);
            Console.WriteLine($"There are {validPassportCount} valid passports!");
        }

        protected override void Assignment2() 
        {
            var validPassportCount = data.Count(x => x.PassportFieldsAreValid);
            Console.WriteLine($"There are {validPassportCount} valid passports with the correct field values!");
        }

        protected override IList<Day4Input> ConvertInput(IList<string> input)
        {
            var content = new List<Day4Input>();

            var result = new Day4Input();
            foreach(var line in input)
            {
                if(string.IsNullOrEmpty(line)) 
                {
                    content.Add(result);
                    result = new Day4Input();
                    continue;
                }

                ParseLine(line, result);
            }
            content.Add(result);

            return content;
        }

        private void ParseLine(string line, Day4Input input) 
        {
            var pairs = line.Split(' ');
            foreach(var pair in pairs) 
            {
                var fields = pair.Split(':');
                input.Fields.Add(fields[0], fields[1]);
            }
        }
    }
}