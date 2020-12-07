using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AdventOfCode2020.Helpers;

namespace AdventOfCode2020 
{
    public class Day1 : Day<List<int>>
    {
        public override string Title => "Day 1";

        protected override void Assignment1() 
        {
            int number1 = 0, number2 = 0;
            for(var i = 0; i <= data.Count; i++) 
            {
                var found = false;
                var number = data[i];
                var j = i + 1;
                var sum = number + data[j];
                do 
                {
                    if(sum == 2020) 
                    {
                        number1 = number;
                        number2 = data[j];
                        Console.WriteLine($"The following 2 numbers sum up to 2020: {number1} and {number2}");
                        found = true;
                        break;
                    }

                    j++;
                    sum = number + data[j];
                }
                while (sum <= 2020);
                if(found) 
                {
                    break;
                }
            }

            Console.WriteLine($"The 2 found numbers are multiplied together: {number1*number2}");

        }

        protected override void Assignment2() 
        {
            int number1 = 0, number2 = 0, number3 = 0;
            for(var i = 0; i < data.Count - 2; i++) 
            {
                var found = false;
                var tempNumber1 = data[i];

                for(var j = i + 1; j < data.Count - 1; j++)
                {   
                    var tempNumber2 = data[j];
                    var k = j + 1;    
                    var tempNumber3 = data[k];
                    var sum = tempNumber1 + tempNumber2 + tempNumber3;
                    do 
                    {
                        if(sum == 2020) 
                        {
                            number1 = tempNumber1;
                            number2 = tempNumber2;
                            number3 = tempNumber3;
                            Console.WriteLine($"The following 3 numbers sum up to 2020: {number1} and {number2} and {number3}!");
                            found = true;
                            break;
                        }

                        k++;
                        if(k < data.Count){
                            tempNumber3 = data[k];
                            sum = tempNumber1 + tempNumber2 + tempNumber3;
                        }
                    }
                    while (sum <= 2020);
                }
                
                if(found) 
                {
                    break;
                }
            }
            Console.WriteLine($"The 3 found numbers are multiplied together: {number1*number2*number3}");

        }

        protected override async Task<List<int>> ReadData()
        {
            var numbers = new List<int>();
            var input = await FileContentReader.ReadInput(1);
            foreach(var line in input)
            {
                if(int.TryParse(line, out var number))
                {
                    numbers.Add(number);
                }
            }

            return numbers.OrderBy(x => x).ToList();
        }
    }
}