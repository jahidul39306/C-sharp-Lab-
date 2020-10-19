using System;
using System.Diagnostics.Tracing;

namespace LabTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            int n = 50;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // 2


            // 3
            for (int i = 1; i < 6; i++)
            {
                for (int j = i; j < i + 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            // 4
            int odd = 0;
            int even = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) { even = even + i; }
                else { odd = odd + i; }
            }
            Console.WriteLine("Sum of odd number = " + odd);
            Console.WriteLine("Sum of even number = " + even);

            // 5
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < i; j++) { Console.Write(" "); }
                Console.WriteLine(i);
            }

            // 6
            int m = 5;
            int factorial = 1;
            for (int i = 1; i <= m; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial is " + factorial);
        }
    }
}
