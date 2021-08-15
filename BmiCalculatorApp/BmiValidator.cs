using System;
using System.Collections.Generic;
using System.Text;

namespace BmiCalculatorApp
{
    public class BmiValidator
    {
        public string ValidateBmi(double Bmi_Calc)
        {
            if (Bmi_Calc < 18.5)
            { return "Underweight"; }

            else if (Bmi_Calc >= 19 & Bmi_Calc <= 24)
            { return "Healthy"; }

            else 
            { return "Overweight"; }

        }
    }
}
