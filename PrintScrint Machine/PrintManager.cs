using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScanner_Machine
{
    public class PrintManager : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print In Action");
        }
    }
}
