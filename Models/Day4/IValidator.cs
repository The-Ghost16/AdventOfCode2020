namespace AdventOfCode2020.Models.Day4
{
    public interface IValidator
    {
        string Key { get; }

        bool Validate(string value);
    }
}