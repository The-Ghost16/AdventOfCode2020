using System.Collections.Generic;

namespace AdventOfCode2020.Models.Day4
{
    public class EyeColorValidator : IValidator
    {
        private readonly IList<string> Colors = new List<string> { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

        public string Key => "ecl";

        public bool Validate(string value)
        {            
            return Colors.Contains(value);
        }
    }
}