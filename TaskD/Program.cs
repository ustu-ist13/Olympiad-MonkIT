using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TaskD
{
    class Program
    {
        class Test
        {
            public string Place { get; set; }
            public int Scored { get; set; }
            public int Conceded { get; set; }

            public int GetMin()
            {
                var min = Conceded - Scored + 1;
                return min > 30 ? 30 : min < 0 ? 0 : min;
            }

            public int GetMax()
            {
                var curr = 30 - Scored + Conceded;
                var max = Place == "home"
                    ? curr >= Conceded ? curr - 1 : curr
                    : Scored == 30 ? curr - 1 : curr;
                return max > 30 ? 30 : max < 0 ? 0 : max;
            }
        }

        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var regex = new Regex(@"The Machinegunners played (\S+) game, scored (\d+) goals, and conceded (\d+) goals.");
            var tests = new List<Test>();

            while (count-- > 0)
            {
                var match = regex.Match(Console.ReadLine());

                tests.Add(new Test
                {
                    Place = match.Groups[1].Value,
                    Scored = int.Parse(match.Groups[2].Value),
                    Conceded = int.Parse(match.Groups[3].Value),
                });
            }

            tests.ForEach(test => Console.WriteLine($"{test.GetMin()} {test.GetMax()}"));
        }
    }
}
