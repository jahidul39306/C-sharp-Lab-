using System;

namespace Test_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Calculator");
            Console.WriteLine("---------------------");
            //Console.WriteLine();
            Calculator c1 = new Calculator();
            Console.WriteLine("Sum of two numbers: " +c1.sum(54, 98));
            Console.WriteLine("Sub of two numbers: " +c1.sub(54, 64));
            Console.WriteLine("Multiplication of two numbers: " +c1.multiplication(9, 9));
            Console.WriteLine("Division of two numbers: " +c1.division(81, 9));
            Console.WriteLine("5 to the power 6: " +c1.XtoY(5, 6));
            Console.WriteLine("Square Root of 36: " +c1.SquareRoot(36));
            Console.WriteLine("Cube Root of 125: " +c1.CubeRoot(125));
            Console.WriteLine("Log of 63 with base 4: " +c1.Log(63, 4));
            Console.WriteLine("---------------------");
        }
    }
}
