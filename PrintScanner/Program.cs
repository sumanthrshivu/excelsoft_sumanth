using System;

namespace PrintScannerProgram
{
    class Program
    {
        public static void Main()
        {
            Printer _printerRef = new Printer();
            Scanner _scannerRef = new Scanner();

            PrintManager _printManager = new PrintManager();
            _printManager.PrintDocument(_printerRef);

            SacnManager _scanManager = new SacnManager();
            _scanManager.ScanDocument(_scannerRef);

            PrintScanner _printScanner = new PrintScanner();
            _printManager.PrintDocument(_printScanner);
            _scanManager.ScanDocument(_printScanner);


        }
    }
}
