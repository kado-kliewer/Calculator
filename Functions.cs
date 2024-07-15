using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class Functions
    {
        public double Circumference(double radius)
        {
            double cir = double.NaN;

            try
            {
                if (radius == double.NaN)
                {
                    throw new Exception("The radius was not provided");
                }
                cir = (2 * Math.PI) * radius;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return cir;
        }

        /// <summary>
        ///  Calculates the radius based off the circumference of a circle
        /// </summary>
        /// <param name="cir"></param>
        /// <returns>A <see cref="double"/></returns>
        public double Radius(double cir)
        {
            double radius = double.NaN;

            try
            {
                if (cir == double.NaN)
                {
                    throw new Exception("The circumference was not provided!");
                }
                radius = cir / (2 * Math.PI);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return radius;
        }

        /// <summary>
        ///  Calculates the radius based off of the circles diameter
        /// </summary>
        /// <param name="diameter"></param>
        /// <returns>A <see cref="double"/></returns>
        public double RadiusFromDiameter(double diameter)
        {
            double radius = double.NaN;

            try
            {
                if (diameter == double.NaN)
                {
                    throw new Exception("The diameter was not provided!");
                }

                radius = diameter / 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return radius;
        }

        /// <summary>
        ///  Calculates the diamter of a given cirlce
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>A <see cref="double"/></returns>
        public double Diameter(double radius)
        {
            var dia = double.NaN;

            try
            {
                if(radius == double.NaN)
                {
                    throw new Exception("The radius was not provided!");
                }

                dia = 2 * radius;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dia;
        }
    }
}
