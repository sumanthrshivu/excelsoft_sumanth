using System;

namespace PrintScanner_Machine

{
    class Program
    {
        public static void Main()
        {

            PrintManager _printDocument = new PrintManager();
            _printDocument.Print();

            ScanManager _scanDcoument = new ScanManager();
            _scanDcoument.Scan();

            PrintScanner _printScan = new PrintScanner(_printDocument, _scanDcoument);
            _printScan.PrintDcoument();
            _printScan.ScanDcoument();
        }
    }
}