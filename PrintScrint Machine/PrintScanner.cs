using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScanner_Machine
{
    public class PrintScanner
    {
        IPrinter _printer;
        IScanner _scanner;

        public PrintScanner(IPrinter printer, IScanner scanner)
        {
            this._printer = printer;
            this._scanner = scanner;
        }

        public void PrintDcoument()
        {
            _printer.Print();
           
        }
        public void ScanDcoument()
        {
            
            _scanner.Scan();
        }


    }
}
