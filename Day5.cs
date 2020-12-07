using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AdventOfCode2020.Models;

namespace AdventOfCode2020
{
    public class Day5
    {
        private IList<Day5Input> data;

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
            var highestSeatId = data.Max(x => x.SeatId);
            Console.WriteLine($"The boarding pass with the highest seat id {highestSeatId}");
        }

        private void Assignment2() 
        {
            var orderedData = data.Where(x => x.Row != 0 && x.Row != 127).OrderBy(x => x.SeatId).ToList();

            var i = 0;
            var found = false;
            do
            {
                var seatId1 = orderedData[i].SeatId;
                var seatId2 = orderedData[i+1].SeatId;

                if(seatId2 - seatId1 == 2)
                {
                    found = true;
                } 
                else 
                {
                    i++;
                }
            }
            while(found == false);

            Console.WriteLine($"The boarding pass seat id should be: {orderedData[i].SeatId + 1}");
        }
        
        private async Task<IList<Day5Input>> ReadData() 
        {
            var content = new List<Day5Input>();

            using(var sr = new StreamReader($"inputs\\day5.txt"))
            {
                while(sr.EndOfStream == false)
                {
                    var line = await sr.ReadLineAsync();
                    var input = new Day5Input(line);
                    content.Add(input);
                }
            }

            return content;
        }
    }
}