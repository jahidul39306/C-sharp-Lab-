using System;
using System.Diagnostics.Tracing;

namespace LabTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Number 1:");
            int n = 50;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // 2
            Console.WriteLine("\nNumber 2:");
            string a = "X0X0X0";
            string b = "0X0X0X";
            for (int i = 1; i < 5; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(b); }
                else Console.WriteLine(a);
            }
            
            // 3
            Console.WriteLine("\nNumber 3:");
            for (int i = 1; i < 6; i++)
            {
                for (int j = i; j < i + 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
            // 4
            Console.WriteLine("\nNumber 4:");
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
            Console.WriteLine("\nNumber 5:");
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < i; j++) { Console.Write(" "); }
                Console.WriteLine(i);
            }

            // 6
            Console.WriteLine("\nNumber 6:");
            int m = 5;
            int factorial = 1;
            for (int i = 1; i <= m; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial is " + factorial);

            // 7
            Console.WriteLine("\nNumber 7:");
            int p = 5;
            for (int i = 1; i <= p; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = p - 1; i > 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
