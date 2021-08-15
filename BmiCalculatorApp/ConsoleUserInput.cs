using System;
using System.Collections.Generic;
using System.Text;

namespace BmiCalculatorApp
{
    public class ConsoleUserInput
    {
        public static int GetUserWeight()
        {
            ConsoleDisplay.WriteFromConsole("Enter the Weight in kilogram: ");
            int height= Convert.ToInt32(ConsoleDisplay.ReadFromConsole());
            return height;
        }

        public static double GetUserHeight()
        {
            ConsoleDisplay.WriteFromConsole("Enter the  Height in meters: ");
            double weight = Convert.ToDouble(ConsoleDisplay.ReadFromConsole());
            return weight;
        }
    }
}
