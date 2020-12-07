using System;

namespace AdventOfCode2020.Models
{
    public class Day5Input
    {
        private readonly string data;
        public Day5Input(string data)
        {
            this.data = data;
        }

        public string RowDefinition => data.Substring(0, 7);

        public int Row 
        {
            get 
            {
                var binary = RowDefinition.Replace('F', '0').Replace('B', '1');
                return Convert.ToInt32(binary, 2);
            }
        }

        public string SeatDefinition => data.Substring(7, 3);

        public int Seat 
        {
            get 
            {
                var binary = SeatDefinition.Replace('L', '0').Replace('R', '1');
                return Convert.ToInt32(binary, 2);
            }
        }

        public int SeatId => (Row * 8) + Seat;
    }
}