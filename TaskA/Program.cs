using System;

namespace TaskA
{
    class Program
    {
        static void Main(string[] args) => Console.WriteLine((12 - int.Parse(Console.ReadLine()))*45 > 4*60 ? "NO" : "YES");
    }
}
