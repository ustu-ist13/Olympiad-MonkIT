using System;
using System.Linq;

namespace TaskE
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = Console.ReadLine().Split().Select(int.Parse).ToList()[1];
            var bumbums = 0;
            var droids = 0;

            Console.ReadLine().Split().Select(int.Parse).ToList().ForEach(x =>
            {
                if (x > k) bumbums += x - k;
                else droids += k - x;
            });

            Console.WriteLine($"{bumbums} {droids}");
        }
    }
}
