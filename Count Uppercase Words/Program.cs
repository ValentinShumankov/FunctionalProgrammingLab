using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main( string [ ] args )
        {
            Func<string,bool> upperCheck = x => char.IsUpper(x[0]);
            string[] upperWords = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(upperCheck).ToArray();
            Console.WriteLine(string.Join("\n",upperWords));

        }
    }
}
