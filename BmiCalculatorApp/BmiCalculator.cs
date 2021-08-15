using System;
using System.Collections.Generic;
using System.Text;


namespace BmiCalculatorApp
{
    public class BmiCalculator
    {
        double bmi;
        public double CalculateBmi(double Weight_Kg, double Height_M) //body mass index calculation
        {  
            try
            {
                bmi= Weight_Kg / Height_M;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("caught zero" +e);
            }
            return bmi;
        }
         
    }
}
