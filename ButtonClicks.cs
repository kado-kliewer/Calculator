using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    ///  A boolean class of mathematical operators
    /// </summary>
    public class ButtonClicks
    {
        public bool? IsAddition { get; set; } = false;

        public bool? IsSubtraction { get; set; } = false;

        public bool? IsMultiplication { get; set; } = false;

        public bool? IsDivision { get; set; } = false;

        /// <summary>
        ///  Checks to see which operation we will be performing
        /// </summary>
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

        /// <summary>
        ///  Resets the chosen operation to ensure that calculations are correct.
        /// </summary>
        public void Reset()
        {
            IsAddition = false;
            IsSubtraction = false;
            IsDivision = false;
            IsMultiplication = false;
        }
    }
}
