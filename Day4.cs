using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AdventOfCode2020.Models;

namespace AdventOfCode2020
{
    public class Day4
    {
        private IList<Day4Input> data;

        public async Task Run() 
        {
            data = await ReadData();

            Console.WriteLine("Start with executing assignment 1!");
            Assignment1();
            Console.WriteLine("Finished with executing assignment 1!");
            
            Console.WriteLine("Start with executing assignment 2!");
            Assignment2();
            Console.WriteLine("Finished with executing assignment 2!");
        }

        private void Assignment1()
        {
            var validPassportCount = data.Count(x => x.IsValidPassport);
            Console.WriteLine($"There are {validPassportCount} valid passports!");
        }

        private void Assignment2() 
        {
        }
        
        private async Task<IList<Day4Input>> ReadData() 
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