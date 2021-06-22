using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class RDSDataModel
    {
        private int counterpartyid;
        private string name;

        public int rds_cpid
        {
            get { return this.counterpartyid; }
            set { this.counterpartyid = value; }
        }

        public string rds_name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
