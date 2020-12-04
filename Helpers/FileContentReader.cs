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

            using(var sr = new StreamReader($"inputs\\day{dayNumber}.txt"))
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