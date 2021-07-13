using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputLib
{
    public class UserInputType
    {
        public static void UserInput()
        {
            ConsoleDisplayLib.ConsoleDisplayType.DisplayMessage("Enter the Weight in kilogram: ");
            double Weight_Kilograms = Convert.ToDouble(ConsoleDisplayLib.ConsoleDisplayType.ReadFromConsole());

            ConsoleDisplayLib.ConsoleDisplayType.DisplayMessage("Enter the Height in Meters: ");
            double Height_Meters = Convert.ToDouble(ConsoleDisplayLib.ConsoleDisplayType.ReadFromConsole());

            CalculateBmiLib.CalculateBmiType _calculateBmiType = new CalculateBmiLib.CalculateBmiType();
            double BMI_Cal = _calculateBmiType.Bmicalculator(Height_Meters, Weight_Kilograms);

            BmiValidateLib.ValidateBmiType _validateBmi = new BmiValidateLib.ValidateBmiType();
            string message = _validateBmi.Check_BmiValue(BMI_Cal);

            ConsoleDisplayLib.ConsoleDisplayType.DisplayMessage(message);
        }
        public static void CsvInputToBmiCalculator()
        {
            PatientDetailsReadFromCsvLib.ReadFromCsvType _csvReader = new PatientDetailsReadFromCsvLib.ReadFromCsvType();
            List<ModelsLib.PatientDetails> patients = _csvReader.GetALlPatientDetails(@"F:\c# training\BmiCalculationLibApp\PatientDetailsData.csv");

            for (int i = 0; i < patients.Count; i++)
            {
                ModelsLib.PatientDetails _patientDetails = patients[i];
                CalculateBmiLib.CalculateBmiType _calculateBmiType = new CalculateBmiLib.CalculateBmiType();
                double BMI_Cal = _calculateBmiType.Bmicalculator(_patientDetails.height, _patientDetails.weight);

                BmiValidateLib.ValidateBmiType _validateBmi = new BmiValidateLib.ValidateBmiType();
                string message = _validateBmi.Check_BmiValue(BMI_Cal);

                ConsoleDisplayLib.ConsoleDisplayType.DisplayMessage(message);
            }

        }
    }
}
