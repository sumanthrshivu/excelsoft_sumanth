using System;
using System.Collections.Generic;
using System.Text;


namespace BmiCalculatorApp
{
    public class BmiCalculator
    {
        public double CalculateBmi(double Weight_Kg, double Height_M) //body mass index calculation
        {
                return Weight_Kg / Height_M;
        }
         
    }
}
