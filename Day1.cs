using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode2020 
{
    public class Day1
    {
        public async Task Run() 
        {
            var numbers = await ReadNumbersFromFile();
            var orderedNumbers = numbers.OrderBy(x => x).ToList();

            Console.WriteLine("Start with executing assignment 1!");
            Assignment1(orderedNumbers);
            Console.WriteLine("Finished with executing assignment 1!");
            
            Console.WriteLine("Start with executing assignment 2!");
            Assignment2(orderedNumbers);
            Console.WriteLine("Finished with executing assignment 2!");
        }

        private void Assignment1(IList<int> input) 
        {
            int number1 = 0, number2 = 0;
            for(var i = 0; i <= input.Count; i++) 
            {
                var found = false;
                var number = input[i];
                var j = i + 1;
                var sum = number + input[j];
                do 
                {
                    if(sum == 2020) 
                    {
                        number1 = number;
                        number2 = input[j];
                        Console.WriteLine($"The following 2 numbers sum up to 2020: {number1} and {number2}");
                        found = true;
                        break;
                    }

                    j++;
                    sum = number + input[j];
                }
                while (sum <= 2020);
                if(found) 
                {
                    break;
                }
            }

            Console.WriteLine($"The 2 found numbers are multiplied together: {number1*number2}");

        }

        private void Assignment2(IList<int> input) 
        {
            int number1 = 0, number2 = 0, number3 = 0;
            for(var i = 0; i < input.Count - 2; i++) 
            {
                var found = false;
                var tempNumber1 = input[i];

                for(var j = i + 1; j < input.Count - 1; j++)
                {   
                    var tempNumber2 = input[j];
                    var k = j + 1;    
                    var tempNumber3 = input[k];
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
                        if(k < input.Count){
                            tempNumber3 = input[k];
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

        private async Task<IList<int>> ReadNumbersFromFile()
        {
            var numbers = new List<int>();
            using(var sr = new StreamReader("inputs\\day1.txt"))
            {
                var line = await sr.ReadLineAsync();
                do
                {
                    if(int.TryParse(line, out var number))
                    {
                        numbers.Add(number);
                    }

                    line = await sr.ReadLineAsync();
                }
                while(string.IsNullOrEmpty(line) == false);
            }

            return numbers;
        }
    }
}