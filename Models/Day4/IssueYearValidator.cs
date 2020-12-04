namespace AdventOfCode2020.Models.Day4
{
    public class IssueYearValidator : IValidator
    {
        public string Key => "iyr";

        public bool Validate(string value)
        {
            if(int.TryParse(value, out var year)) 
            {
                return year >= 2010 && year <= 2020;
            }

            return false;
        }
    }
}