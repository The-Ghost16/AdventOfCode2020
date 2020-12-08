using System.Collections.Generic;
using AdventOfCode2020.Models.Day7;

namespace AdventOfCode2020.Models
{
    public class Day7Input
    {
        public Day7Input()
        {
            Bags = new List<Bag>();
        }

        public IList<Bag> Bags { get; set; }
    }
}