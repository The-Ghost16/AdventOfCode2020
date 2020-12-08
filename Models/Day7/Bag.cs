using System.Collections.Generic;

namespace AdventOfCode2020.Models.Day7
{
    public class Bag 
    {
        public Bag()
        {
            ChildBags = new Dictionary<string, int>();
        }

        public string Name { get; set; }

        public IDictionary<string, int> ChildBags { get; set; }
    }
}