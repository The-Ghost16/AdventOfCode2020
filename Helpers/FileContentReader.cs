using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AdventOfCode2020.Helpers
{
    public static class FileContentReader
    {
        public static async Task<IList<string>> ReadInput(int dayNumber) 
        {
            var content = new List<string>();
            var file = Path.Combine("inputs", $"day{dayNumber}.txt");
            using(var sr = new StreamReader(file))
            {
                while(sr.EndOfStream == false)
                {
                    var line = await sr.ReadLineAsync();
                    content.Add(line);
                }
            }

            return content;
        }
    }
}