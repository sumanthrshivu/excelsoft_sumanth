using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BmiCalculationLibApp
{
    public enum Options
    {
        ConsoleInput = 1, FileInput
            
    }
    class Program
    {
       //static int count = 3;
       
        static void Main(string[] args)
        {
            //do
            //{
                //Options _choice = default(Options);
                string displayMsg = $"Enter Your Choice {(int)Options.ConsoleInput}->ConsoleInput,{(int)Options.FileInput}-->FileInput";
                ConsoleDisplayLib.ConsoleDisplayType.DisplayMessage(displayMsg);
                Options _choice = (Options)Convert.ToDouble(ConsoleDisplayLib.ConsoleDisplayType.ReadFromConsole());
                    //    try
                    //    {
                    //        double optionValue = Convert.ToDouble(ConsoleDisplayLib.ConsoleDisplayType.ReadFromConsole());

                    //        if (optionValue < 1 || optionValue > 2)
                    //        {
                    //            Console.WriteLine("invalid options");
                    //        }
                    //        else
                    //        {
                    //            break;
                    //        }
                    //    }

                    //    catch (FormatException ex)
                    //    {
                    //        Console.WriteLine("choosed options must be number");
                    //    }
                    //    --count;
                    //} while (count > 0);
            switch (_choice)
            {
                case Options.ConsoleInput:
                    UserInputLib.UserInputType.UserInput();
                    break;

                case Options.FileInput:
                    try
                    {
                        UserInputLib.UserInputType.CsvInputToBmiCalculator();
                    }

                    catch (FileNotFoundException e)
                    { 
                        Console.WriteLine("Could Not Find File" + e);  
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Please provide valid type" + ex);
                    }
                    Console.ReadKey();
                    break;
           
            }
        }
    }
}
