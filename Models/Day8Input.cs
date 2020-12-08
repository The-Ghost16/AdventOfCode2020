namespace AdventOfCode2020.Models
{
    public class Day8Input
    {
        private readonly string line;

        public Day8Input(string line)
        {
            this.line = line;
        }

        public string Command => line.Substring(0, 3);

        public string Sign => line.Substring(4, 1);

        public int Amount => int.Parse(line.Substring(5));

        public bool IsPositive => Sign == "+";
    }
}