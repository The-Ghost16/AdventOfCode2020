using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdventOfCode2020.Helpers;

namespace AdventOfCode2020
{
    public abstract class Day<T> : IDay
    {
        private readonly int day;

        protected T data;

        public Day(int day)
        {
            this.day = day;
        }
        
        public string Title => $"Day {day}";

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

        protected virtual void Assignment1()
        {

        }

        protected virtual void Assignment2()
        {
            
        }

        private async Task<T> ReadData()
        {
            var input = await FileContentReader.ReadInput(day);
            return ConvertInput(input);
        }

        protected abstract T ConvertInput(IList<string> input);
    }
}