using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class TDSDataModel
    {
        private string tradeid;
        private int date;
        private double tradevalue;
        private int counterpartyid;

        public string tds_tradeid
        {
            get { return this.tradeid; }
            set { this.tradeid=value; }
        }

        public int tds_date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public double tds_tradevalue
        {
            get { return this.tradevalue; }
            set { this.tradevalue = value; }
        }

        public int tds_cpid
        {
            get { return this.counterpartyid; }
            set { this.counterpartyid = value; }
        }
    }
}
