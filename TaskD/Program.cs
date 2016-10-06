﻿using System;
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

            tests.ForEach(test =>
            {
                var min = test.Conceded - test.Scored + 1;
                if (min < 0) min = 0;
                if (min > 30) min = 30;

                var curr = 30 - test.Scored + test.Conceded;
                var max = test.Place == "home"
                    ? curr >= test.Conceded ? curr - 1 : curr
                    : test.Scored == 30 ? curr - 1 : curr;
                if (max < 0) max = 0;
                if (max > 30) max = 30;

                Console.WriteLine($"{min} {max}");
            });
        }
    }
}