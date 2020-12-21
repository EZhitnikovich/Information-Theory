using System;
using System.Collections.Generic;
using System.Text;

namespace TI2
{
    public static class BetweenNums
    {
        public static bool Between(this double num, double lower, double upper)
        {
            return lower < num && num <= upper;
        }
    }
}
