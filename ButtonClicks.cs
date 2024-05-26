using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class ButtonClicks
    {
        public bool? IsAddition { get; set; } = false;

        public bool? IsSubtraction { get; set; } = false;

        public bool? IsMultiplication { get; set; } = false;

        public bool? IsDivision { get; set; } = false;

        public void Check()
        {
            if((bool)IsAddition)
            {
                IsDivision = false;
                IsMultiplication = false;
                IsSubtraction = false;
            }
            else if((bool)IsSubtraction)
            {
                IsDivision = false;
                IsMultiplication = false;
                IsSubtraction = false;
            }
            else if((bool)IsDivision)
            {
                IsAddition = false;
                IsMultiplication = false;
                IsSubtraction = false;
            }
            else if((bool)IsMultiplication)
            {
                IsAddition = false;
                IsDivision = false;
                IsSubtraction = false;
            }
        }
    }
}
