using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Value1
    {
        public Value1(double x)
        {
            Value = x;
        }

        public double Value { get; set; } = double.NaN;
    }

    public class Value2
    {
        public Value2(double x)
        {
            Value = x;
        }
        public double Value { get; set; }
    }
}
