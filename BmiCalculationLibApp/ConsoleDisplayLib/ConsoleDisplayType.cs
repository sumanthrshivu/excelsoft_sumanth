using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDisplayLib
{
    public class ConsoleDisplayType
    {
        public static string  DisplayMessage(string message)
        {
           Console.WriteLine(message);
            return message;
          
            
        }

        public static double ReadFromConsole()
        {
            double value = Convert.ToDouble(Console.ReadLine());
            return value;
        }
      
    }
}
