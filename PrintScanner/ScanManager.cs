using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerProgram
{
    public class SacnManager
    {
        IScanner _scanner;
        public void ScanDocument(Scanner scanner)
        {
            this._scanner = scanner;
        }
    }
}
