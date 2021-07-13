using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScanner_Machine

{
    public class Printer : IPrinter 
    {
        public void Print()
        {
            Console.WriteLine("print is in action");
        }
    }
}
