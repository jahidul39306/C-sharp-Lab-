using System;

namespace LabTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Hello");
            Console.WriteLine("Jahidul Islam Noor");

            // 2
            Console.WriteLine(5 + 9);

            // 3
            Console.WriteLine(36 / 6);

            // 4
            Console.WriteLine(-5 + 8 * 6);
            Console.WriteLine((55 + 9) % 9);
            Console.WriteLine(20 + (-3 * 5) / 8);
            Console.WriteLine(5 + 15 / 3 * 2 - 8 % 3);

            // 5
            double x = 59.8;
            double y = 42.3;
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);

            // 6
            Console.WriteLine((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));

            // 7
            double width = 5.5;
            double height = 8.5;
            Console.WriteLine("Area is " + width + " * " + height + " = " + (width * height));
            Console.WriteLine("Perimeter is 2 * (" + width + " + " + height + ") = " + 2 * (width + height));
        }
    }
}
