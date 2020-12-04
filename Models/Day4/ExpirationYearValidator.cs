namespace AdventOfCode2020.Models.Day4
{
    public class ExpirationYearValidator : IValidator
    {
        public string Key => "eyr";

        public bool Validate(string value)
        {
            if(int.TryParse(value, out var year)) 
            {
                return year >= 2020 && year <= 2030;
            }

            return false;
        }
    }
}