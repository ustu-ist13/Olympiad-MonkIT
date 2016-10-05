using System;
using System.Linq;

namespace TaskC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            var sections = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sums = Enumerable.Range(0, sections.Count - 2).Select(x => sections.GetRange(x, 3).Sum());
            var max = sums.Max();

            Console.WriteLine($"{max} {sums.ToList().IndexOf(max) + 2}");
        }
    }
}
