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
            set { X = value; }
            get { return X; }
        }
        public int Y
        {
            set { Y = value; }
            get { return Y; }
        }
        public int Z
        {
            set { Z = value; }
            get { return Z; }
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
            if(X == Z && Y == Z) { Console.WriteLine("The triangle is equilateral (3 equal sides)"); }
            else if (X == Z || Y == Z || X == Y) { Console.WriteLine("The triangle is isosceles (2 equal sides)"); }
            else { Console.WriteLine("The triangle is scalene(no equal sides)"); }
        }
    }
}
