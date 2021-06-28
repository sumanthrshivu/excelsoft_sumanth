using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerProgram 
{

    public class PrintManager
    {
        IPrinter _Printer;
        public void PrintDocument(Printer printer)
        {
            this._Printer = printer;
        }

    }
}
