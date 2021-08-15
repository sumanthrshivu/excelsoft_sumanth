using System;

namespace BmiCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestMyBmi bmi = new TestMyBmi();

                while(true)
                {
                    
                    bmi.Weight_Kg = ConsoleUserInput.GetUserWeight();
                    
                    while(bmi.Weight_Kg <= 0)
                    {
                        ConsoleDisplay.WriteFromConsole("Please enter the weight above zero");
                        bmi.Weight_Kg = ConsoleUserInput.GetUserWeight();
                    } 
                    break;
                }
                while (true)
                {

                    bmi.Height_M = ConsoleUserInput.GetUserHeight();

                    while(bmi.Height_M <= 0)
                    {
                        ConsoleDisplay.WriteFromConsole("Please enter the height above zero");
                        bmi.Height_M = ConsoleUserInput.GetUserHeight();  
                    }
                    break;
                }
                
                  while(true)  {
                        BmiCalculator _calculator = new BmiCalculator();
                        double Bmi_Calc = _calculator.CalculateBmi(bmi.Weight_Kg, bmi.Height_M);

                        BmiValidator _bmiValidator = new BmiValidator();
                        string message = _bmiValidator.ValidateBmi(Bmi_Calc);

                        ConsoleDisplay.WriteFromConsole(message);
                        break;
                    }
            }
            catch(FormatException)
            {
                ConsoleDisplay.WriteFromConsole("Please provide the details in numbers");
            }
        }
    }
}