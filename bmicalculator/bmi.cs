using System;
using System.Collections.Generic;
using System.Text;

namespace bmicalculator
{
    class bmi
    {
        private int kg;
        private double m;
        private double bmical;

        public int weight_kg
        {
            set { this.kg = value; }
            get { return this.kg; }
        }

        public double height_m
        {
            set { this.m = value; }
            get { return this.m; }
        }

        public double bmi_calc
        {
            set { this.bmical = value; }
            get { return this.bmical; }
        }

    }

   
}
