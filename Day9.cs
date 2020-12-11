using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020
{
    public class Day9 : Day<IList<long>>
    {
        private long invalidNumber = 0;

        public Day9() : base(9)
        {            
        }

        protected override void Assignment1()
        {
            invalidNumber = FindNumber(25);
            Console.WriteLine($"The first number is: {invalidNumber}");
        }

        protected override void Assignment2()
        {
            var weakness = FindWeakness();
            Console.WriteLine($"The weakness number is: {weakness}");
        }

        protected override IList<long> ConvertInput(IList<string> input)
        {
            return input.Select(x => long.Parse(x)).ToList();
        }

        private long FindNumber(int preamble)
        {
            long number = 0;
            var index = 0;

            do
            {
                var numbers = data.Skip(index).Take(preamble).ToList();
                var numberToFind = data[index + preamble];
                var isFound = false;

                for(var i = 0; i < numbers.Count - 1; i++) 
                {
                    var secondList = numbers.Skip(i);
                    foreach(var x in secondList) 
                    {
                        if(x + numbers[i] == numberToFind)
                        {
                            isFound = true;
                            break;
                        }
                    }

                    if(isFound)
                    {
                        break;
                    }
                }

                if(isFound == false) 
                {
                    number = numberToFind;
                }

                index++;
            }
            while(index + preamble < data.Count && number == 0);

            return number;
        }

        private long FindWeakness()
        {
            var i = 0;
            long weakness = 0;

            do
            {
                var sum = data[i];
                var next = i + 1;

                while(sum < invalidNumber && next < data.Count)
                {
                    sum += data[next];
                    next++;
                }

                if(sum == invalidNumber)
                {
                    var numbers = data.Skip(i).Take(next - i);
                    var min = numbers.Min();
                    var max = numbers.Max();
                    weakness = min + max;
                }

                i++;
            }
            while(weakness == 0);

            return weakness;
        }
    }
}