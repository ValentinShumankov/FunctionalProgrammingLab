using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main( string [ ] args )
        {
            decimal[] numbers = Console.ReadLine().Split(", ").
                Select(decimal.Parse).
                Select(x => x * 1.2m).
                ToArray();
            Console.WriteLine(string.Join("\n", numbers.Select(x => $"{x:f2}")));
        }
    }
}
