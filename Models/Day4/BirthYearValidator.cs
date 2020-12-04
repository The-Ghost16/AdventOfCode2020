namespace AdventOfCode2020.Models.Day4
{
    public class BirthYearValidator : IValidator
    {
        public string Key => "byr";

        public bool Validate(string value)
        {
            if(int.TryParse(value, out var year)) 
            {
                return year >= 1920 && year <=2002;
            }

            return false;
        }
    }
}