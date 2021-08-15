using System;
using System.Collections.Generic;
using System.Text;

namespace BmiCalculatorApp
{
    public class TestMyBmi
    {
        private int weight;
        private double height;

        public int Weight_Kg // kilogram
        {
            set { this.weight = value; }
            get { return this.weight; }
        }

        public double Height_M // meters
        {
            set { this.height = value; }
            get { return this.height; }
        }
    }
}
