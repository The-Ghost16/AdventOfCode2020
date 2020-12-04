using System.Collections.Generic;

namespace AdventOfCode2020.Models 
{
    public class Day4Input
    {
        private readonly IList<string> RequiredFields = new List<string> { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };

        private readonly IList<string> OptionalFields = new List<string> { "cid" };

        public Day4Input()
        {
            Fields = new Dictionary<string, string>();
        }

        public IDictionary<string, string> Fields { get; set; }

        public bool IsValidPassport
        {
            get 
            {
                var isValid = true;
                foreach(var field in RequiredFields)
                {
                    if(Fields.ContainsKey(field) == false) 
                    {
                        isValid = false;
                        break;
                    }
                }

                return isValid;
            }
        }
    }
}