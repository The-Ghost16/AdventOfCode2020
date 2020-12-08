using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Models
{
    public class Day6Input
    {
        public Day6Input()
        {
            Answers = new List<string>();
        }

        public IList<string> Answers { get; set; }

        public int AnyAnsweredQuestions => Answers.SelectMany(x => x.ToCharArray()).Distinct().Count();

        public int AllAnsweredQuestions => Answers.SelectMany(x => x.ToCharArray()).GroupBy(x => x).Select(x => x.Count()).Where(x => x == Answers.Count).Count();
    }
}