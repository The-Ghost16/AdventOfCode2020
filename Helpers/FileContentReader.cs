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
                var line = await sr.ReadLineAsync();
                do
                {
                    content.Add(line);

                    line = await sr.ReadLineAsync();
                }
                while(string.IsNullOrEmpty(line) == false);
            }

            return content;
        }
    }
}