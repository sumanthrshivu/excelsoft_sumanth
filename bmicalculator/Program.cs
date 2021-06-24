using System;

namespace bmicalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bmi b = new bmi();
            Console.Write("Weight in kg: ");
            b.weight_kg = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height in m: ");
            b.height_m = Convert.ToDouble(Console.ReadLine());

            b.bmi_calc= b.weight_kg / b.height_m * 2;

            if (b.bmi_calc < 18.5)
            { Console.WriteLine("-> Underweight"); }
            if (b.bmi_calc >= 19 & b.bmi_calc <= 24)
            { Console.WriteLine("-> healthy"); }
            if (b.bmi_calc >= 25)
            { Console.WriteLine("-> Overweight"); }


            Console.ReadLine();
        }
    }
}
