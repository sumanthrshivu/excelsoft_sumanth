using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            TDSDataModel t1 = new TDSDataModel();
            RDSDataModel r1 = new RDSDataModel();


            t1.tds_tradeid = "sumanth";
            t1.tds_date = 22;
            t1.tds_tradevalue = 20.0406;
            t1.tds_cpid = 2406;

            r1.rds_cpid = 2000;
            r1.rds_name = "akshay";

            Console.WriteLine(t1.tds_tradeid + " " + t1.tds_date + " " + t1.tds_tradevalue + " " + t1.tds_cpid);
            Console.WriteLine(r1.rds_name + " " + r1.rds_cpid);
        
        }
    }
}
