using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateBmiLib
{
    public class CalculateBmiType
    {
        public double Bmicalculator(double height, double weight)
        {
            double Bmi_Calc = weight / height;
            return Bmi_Calc;
           
        }

    }
}
