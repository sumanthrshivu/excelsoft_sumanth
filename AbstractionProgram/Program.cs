using System;

namespace AbstractionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            DiCorEngine _harrier = new DiCorEngine();
            TATACar _tataCar = new TATACar(_harrier);
            _tataCar.Drive();

            VeriCorEngine _nexon = new VeriCorEngine();
            TATACar _tataCar1 = new TATACar(_nexon);
            _tataCar1.Drive();

            MultiJetEngine _hexa = new MultiJetEngine();
            TATACar _tataCar2 = new TATACar(_hexa);
            _tataCar2.Drive();

            RevorTron _safari= new RevorTron();
            TATACar _tataCar3 = new TATACar(_safari);
            _tataCar3.Drive();

        }
    }
}
