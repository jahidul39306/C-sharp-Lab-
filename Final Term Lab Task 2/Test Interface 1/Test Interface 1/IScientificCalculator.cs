using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_1
{
    interface IScientificCalculator
    {
        double XtoY(int x, int y);
        double SquareRoot(double x);
        double CubeRoot(double x);

        double Log(double x, double logBase);

    }
}
