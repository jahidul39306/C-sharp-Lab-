using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_3
{
    class Triangle
    {
        int x;
        int y;
        int z;
        public int X
        {
            set { x = value; }
            get { return x; }
        }
        public int Y
        {
            set { y = value; }
            get { return y; }
        }
        public int Z
        {
            set { z = value; }
            get { return z; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Value of x: {0}", X);
            Console.WriteLine("Value of y: {0}", Y);
            Console.WriteLine("Value of z: {0}", Z);
            //Console.WriteLine("Value of x: {0}", X);
        }

        public void TestTriangle()
        {
            Console.WriteLine();
            if (X == Z && Y == Z) { Console.WriteLine("The triangle is equilateral (3 equal sides)"); }
            else if (X == Z || Y == Z || X == Y) { Console.WriteLine("The triangle is isosceles (2 equal sides)"); }
            else { Console.WriteLine("The triangle is scalene(no equal sides)"); }
        }
    }
}
