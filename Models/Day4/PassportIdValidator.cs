namespace AdventOfCode2020.Models.Day4
{
    public class PassportIdValidator : IValidator
    {
        public string Key => "pid";

        public bool Validate(string value)
        {
            if(int.TryParse(value, out var id)) 
            {
                return value.Length == 9;
            }

            return false;
        }
    }
}