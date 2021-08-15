using System;
using System.Collections.Generic;
using System.Text;

namespace BmiCalculatorApp
{
    public class ConsoleUserInput
    {
        public static int GetUserWeight()
        {
            int weight;
            ConsoleDisplay.WriteFromConsole("Enter the Weight in kilogram: ");
            weight = Convert.ToInt32(ConsoleDisplay.ReadFromConsole());
            while (weight <= 0)
            {
                ConsoleDisplay.WriteFromConsole("Please enter the weight above zero");
                ConsoleDisplay.WriteFromConsole("-------------------------------------");
                weight = GetUserWeight();
            }
            return weight;
        }

        public static double GetUserHeight()
        {
            double height;
            ConsoleDisplay.WriteFromConsole("Enter the  Height in meters: ");
            height = Convert.ToDouble(ConsoleDisplay.ReadFromConsole());
            while (height <= 0)
            {
                ConsoleDisplay.WriteFromConsole("Please enter the Height above zero");
                ConsoleDisplay.WriteFromConsole("-------------------------------------");
                height = GetUserHeight();
            }
            return height;
        }
    }
}
