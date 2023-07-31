using System;

namespace GenericTypesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new ComparablePair<int, int>(7, 1);
            var q = new ComparablePair<int, int>(5, 5);
            var result = q.CompareTo(p);
            switch (result)
            {
                case 1:
                    Console.WriteLine("q>p");
                    break;
                case 0:
                    Console.WriteLine("q=p");
                    break;
                default:
                    Console.WriteLine("q<p");
                    break;
            }
        }
    }
}