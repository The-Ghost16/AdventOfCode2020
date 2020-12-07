using System;
using System.Threading.Tasks;

namespace AdventOfCode2020
{
    public abstract class Day<T> : IDay
    {
        protected T data;
        
        public virtual string Title { get; }

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

        protected virtual async Task<T> ReadData()
        {
            return default(T);
        }
    }
}