using System;
using System.Collections.Generic;

namespace AdventOfCode2020
{
    public class Day3 : Day<string[,]>
    {
        public Day3() : base(3)
        {            
        }

        protected override void Assignment1()
        {
            var trees = CalculateTrees(data, 3, 1);
            Console.WriteLine($"Total number of trees: {trees}!");
        }

        protected override void Assignment2() 
        {
            var trees1 = CalculateTrees(data, 1, 1);
            var trees2 = CalculateTrees(data, 3, 1);
            var trees3 = CalculateTrees(data, 5, 1);
            var trees4 = CalculateTrees(data, 7, 1);
            var trees5 = CalculateTrees(data, 1, 2);
            Console.WriteLine($"Total number of trees for 1: {trees1}!");
            Console.WriteLine($"Total number of trees for 2: {trees2}!");
            Console.WriteLine($"Total number of trees for 3: {trees3}!");
            Console.WriteLine($"Total number of trees for 4: {trees4}!");
            Console.WriteLine($"Total number of trees for 5: {trees5}!");
            Console.WriteLine($"The answer should be: {trees1*trees2*trees3*trees4*trees5}!");
        }

        private long CalculateTrees(string[,] data, int moveX, int moveY) 
        {            
            long positionX = 0, positionY = 0, trees = 0;

            var height = data.GetLength(0);
            var width = data.GetLength(1);
            while(positionY < height) 
            {
                if(data[positionY, positionX] == "#")
                {
                    trees++;
                }

                positionX = (positionX + moveX) % width;
                positionY = positionY + moveY;
            }

            return trees;
        }

        protected override string[,] ConvertInput(IList<string> input)
        {
            var data = new string[input.Count, input[0].Length];
            for(var i = 0; i < input.Count; i++) 
            {
                var line = input[i];
                for(var j = 0; j < line.Length; j++) 
                {
                    data[i, j] = line[j].ToString();
                }
            }

            return data;
        }
    }
}