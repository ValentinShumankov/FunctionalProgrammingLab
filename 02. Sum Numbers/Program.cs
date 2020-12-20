using System;
using System.IO;

namespace _02._Sum_Numbers_Practice
{
    class Program
    {
        static void Main( string [ ] args )
        {
            Func<int,int,int> sumDeligate = SumNumbers;
            Func<int,int,int> multyplyDeligate = MultiplyNumbers;
            Calculate(5, 5, sumDeligate);
            Calculate(5, 5, multyplyDeligate);
            Calculate(5, 5, ( a, b ) => a * 100 * b * 100);
        }

        static int SumNumbers(int a , int b )
        {
            Console.WriteLine("Summing numbers is the best feeling");
            return a + b;
        }
        static int MultiplyNumbers( int a, int b )
        {
            Console.WriteLine("Multiplyng numbers is the worst feeling");
            return a * b;
        }
        static int Calculate(int a,int b, Func<int,int,int> operation)
        {
            using (StreamWriter writer = new StreamWriter("../../../ResultCalculations.txt",true))
            {
                writer.WriteLine("Start Calculating");
                Console.WriteLine("Start Calculating");
                writer.WriteLine(operation(a, b));
                Console.WriteLine(operation(a,b));
                
            }
            return 0;
        }
    }
}
