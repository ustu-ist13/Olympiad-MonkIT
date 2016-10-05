using System;
using System.Linq;

namespace TaskB
{
    class Program
    {
        static void Main(string[] args)
        {
            var place = Console.ReadLine().ToLower();
            var row = int.Parse(place.Substring(0, place.Length - 1));
            var position = place.Last();

            const string window = "window";
            const string aisle = "aisle";
            const string neither = "neither";

            string result;

            switch (row)
            {
                case 1 - 2:
                    // a bc d
                    result = new[] { 'a', 'd' }.Contains(position) ? window : aisle;
                    break;
                case 3 - 20:
                    // ab cd ef
                    result = new[] { 'a', 'f' }.Contains(position) ? window : aisle;
                    break;
                default:
                    // abc defg hjk
                    result = new[] {'a', 'k'}.Contains(position)
                        ? window
                        : new[] {'c', 'd', 'g', 'h'}.Contains(position) ? aisle : neither;
                    break;

            }

            Console.WriteLine(result);
        }
    }
}
