using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiValidateLib
{
    public class ValidateBmiType
    {

        public string Check_BmiValue(double BMI_Cal)
        {
            if (BMI_Cal < 18.5)
            {
                return "UnderWeight";
            }
            else if (BMI_Cal >= 25)
            {
                return "OverWeight";
            }
            else
            {
                return "Normal";
            }
        }
    }
}
