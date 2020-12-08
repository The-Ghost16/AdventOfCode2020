using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.Models;

namespace AdventOfCode2020
{
    public class Day8 : Day<IList<Day8Input>>
    {
        public Day8() : base(8)
        {
        }

        protected override void Assignment1()
        {
            var acc = CalculateAccumulator();
            Console.WriteLine($"The accumlator value at the end of the first loop is: {acc}");
        }

        protected override void Assignment2()
        {
            var acc = FindCompletedAccumulator();
            Console.WriteLine($"The accumlator value that reaches the end of the code is: {acc}");
        }

        protected override IList<Day8Input> ConvertInput(IList<string> input)
        {
            return input.Select(x => new Day8Input(x)).ToList();
        }

        private int CalculateAccumulator() 
        {
            var readLines = new List<int>();
            var acc = 0;
            var line = 0;

            do
            {
                readLines.Add(line);
                var input = data[line];
                
                if(input.Command == "jmp")
                {
                    if(input.IsPositive)
                    {
                        line += input.Amount;
                    }
                    else 
                    {
                        line -= input.Amount;
                    }

                    continue;
                }
                else 
                {
                    line++;
                }

                if(input.Command == "acc")
                {
                    if(input.IsPositive)
                    {
                        acc += input.Amount;
                    }
                    else 
                    {
                        acc -= input.Amount;
                    }
                }
            }
            while(readLines.Contains(line) == false);

            return acc;
        }       

        private int FindCompletedAccumulator() 
        {
            for(var i = 0; i < data.Count; i ++)
            {
                if(data[i].Command == "acc")
                {
                    continue;
                }

                var copy = new List<Day8Input>();
                copy.AddRange(data);

                var reachedEnd = false;
                var readLines = new List<int>();
                var acc = 0;
                var line = 0;
                do
                {
                    readLines.Add(line);
                    var input = copy[line];
                    var command = input.Command;
                    if(line == i)
                    {
                        if(command == "jmp")
                        {
                            command = "nop";
                        }
                        else if(command =="nop")
                        {
                            command = "jmp";
                        }
                    }
                    
                    if(command == "jmp")
                    {
                        if(input.IsPositive)
                        {
                            line += input.Amount;
                        }
                        else 
                        {
                            line -= input.Amount;
                        }

                        continue;
                    }
                    else 
                    {
                        line++;
                    }

                    if(command == "acc")
                    {
                        if(input.IsPositive)
                        {
                            acc += input.Amount;
                        }
                        else 
                        {
                            acc -= input.Amount;
                        }
                    }

                    reachedEnd = line == copy.Count - 1;
                }
                while(readLines.Contains(line) == false && line < copy.Count);

                if(reachedEnd)
                {
                    return acc;
                }
            }

            return 0;
        }
    }
}