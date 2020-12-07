using System.Threading.Tasks;

namespace AdventOfCode2020
{
    public interface IDay
    {
        string Title { get; }

        Task Run();
    }
}