using System.Linq;

namespace AdventOfCode2020.Models 
{
    public class Day2Input
    {
        public int Minimum {get;set;}

        public int Maximum {get;set;}

        public char Character {get;set;}

        public string Password {get;set;}

        public bool IsValidPassword() 
        {
            var characterCount = Password.ToCharArray().ToList().Count(x => x == Character);

            return characterCount >= Minimum && characterCount <= Maximum;
        }
    }
}