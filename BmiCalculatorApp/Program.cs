using System;

namespace BmiCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    TestMyBmi bmi = new TestMyBmi();

                    bmi.Weight_Kg = ConsoleUserInput.GetUserWeight();

                    bmi.Height_M = ConsoleUserInput.GetUserHeight();

                    BmiCalculator _calculator = new BmiCalculator();
                    double Bmi_Calc = _calculator.CalculateBmi(bmi.Weight_Kg, bmi.Height_M);

                    BmiValidator _bmiValidator = new BmiValidator();
                    string message = _bmiValidator.ValidateBmi(Bmi_Calc);

                    ConsoleDisplay.WriteFromConsole(message);
                    break;
                }
                catch (FormatException)
                {
                    ConsoleDisplay.WriteFromConsole("Please provide the details in numbers");
                    ConsoleDisplay.WriteFromConsole("-------------------------------------");
                }
            }
            
        }
    }
}