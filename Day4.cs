using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AdventOfCode2020.Models;

namespace AdventOfCode2020
{
    public class Day4 : Day<List<Day4Input>>
    {
        public override string Title => "Day 4";

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
        
        protected override async Task<List<Day4Input>> ReadData() 
        {
            var content = new List<Day4Input>();

            using(var sr = new StreamReader($"inputs\\day4.txt"))
            {
                var input = new Day4Input();
                while(sr.EndOfStream == false)
                {
                    var line = await sr.ReadLineAsync();
                    if(string.IsNullOrEmpty(line)) 
                    {
                        content.Add(input);
                        input = new Day4Input();
                        continue;
                    }

                    ParseLine(line, input);
                }
                content.Add(input);
            }

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