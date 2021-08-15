using System;
using System.Collections.Generic;
using System.Text;

namespace BmiCalculatorApp
{
    public class ConsoleDisplay
    {
        public static string WriteFromConsole(string message)
        {
            Console.WriteLine(message);
            return message;
        }
        public static string ReadFromConsole()
        {
          return Console.ReadLine();
            
        }

    }
}
