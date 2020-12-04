using System.Text.RegularExpressions;

namespace AdventOfCode2020.Models.Day4
{
    public class HairColorValidator : IValidator
    {
        public string Key => "hcl";

        public bool Validate(string value)
        {
            if(value.StartsWith("#") && value.Length == 7)
            {
                return Regex.IsMatch(value.Substring(1), @"\A\b[0-9a-fA-F]+\b\Z");
            }

            return false;
        }
    }
}