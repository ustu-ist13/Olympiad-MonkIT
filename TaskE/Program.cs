using System;
using System.Linq;

namespace TaskE
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = Console.ReadLine().Split().Select(int.Parse).ToList()[1];

            // v1
            //var bumbums = 0;
            //var droids = 0;

            //Console.ReadLine().Split().Select(int.Parse).ToList().ForEach(x =>
            //{
            //    if (x > k) bumbums += x - k;
            //    else droids += k - x;
            //});

            //Console.WriteLine($"{bumbums} {droids}");

            // v2
            var bumbums = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine($"{bumbums.Where(x => x > k).Select(x => x - k).Sum()} {bumbums.Where(x => x < k).Select(x => k - x).Sum()}");
        }
    }
}
