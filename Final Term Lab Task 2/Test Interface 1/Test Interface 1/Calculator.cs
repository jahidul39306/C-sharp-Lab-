using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_1
{
    class Calculator:IBasicCalculator, IScientificCalculator
    {
        public int sum(int x, int y)
        {
            return x + y;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }

        public int multiplication(int x, int y)
        {
            return x * y;
        }
        public int division(int x, int y)
        {
            return x / y;
        }

        public double XtoY(int x, int y)
        {
            return Math.Pow(x, y);
        }
        public double SquareRoot(double x)
        {
            return Math.Pow(x, (double) 1 / 2);
        }
        public double CubeRoot(double x)
        {
            return Math.Pow(x, (double)1 / 3);
        }
        public double Log(double x, double logBase)
        {
            return Math.Log(x, logBase);
        }
    }
}
