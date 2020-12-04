namespace AdventOfCode2020.Models.Day4
{
    public class HeightValidator : IValidator
    {
        public string Key => "hgt";

        public bool Validate(string value)
        {
            if(value.EndsWith("in") || value.EndsWith("cm"))
            {
                var numberString = value.Substring(0, value.Length - 2);
                if(int.TryParse(numberString, out var number))
                {
                    return (value.EndsWith("in") && number >= 59 && number <= 76) || (value.EndsWith("cm") && number >= 150 && number <= 193);
                }
            }
            
            return false;
        }
    }
}