using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020
{
    public class Day10 : Day<IList<int>>
    {
        public Day10() : base(10)
        {            
        }

        protected override void Assignment1()
        {
            var diff1 = 0;
            var diff3 = 1; // start with 1 because device is always 3 higher!

            for(var i = 0; i < data.Count - 1; i++)
            {
                var number1 = data[i];
                var number2 = data[i+1];
                var diff = number2 - number1;

                if (i == 0) 
                {
                    if(number1 == 1)
                    {
                        diff1++;
                    }
                    if(number1 == 3)
                    {
                        diff3++;
                    }
                }

                if(diff == 1)
                {
                    diff1++;
                }
                if(diff == 3)
                {
                    diff3++;
                }
            }

            Console.WriteLine($"The number is: {diff1 * diff3}");
        }

        protected override void Assignment2()
        {
            base.Assignment2();
        }

        protected override IList<int> ConvertInput(IList<string> input)
        {
            return input.Select(int.Parse).OrderBy(x => x).ToList();
        }
    }
}