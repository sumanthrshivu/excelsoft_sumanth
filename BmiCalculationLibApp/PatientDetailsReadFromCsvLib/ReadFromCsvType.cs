using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDetailsReadFromCsvLib
{
    public class ReadFromCsvType
    {

        public List<ModelsLib.PatientDetails> GetALlPatientDetails(string path)
        { 
            List<string> lines = GetALLLines(path);
            List<ModelsLib.PatientDetails> _patientsList = new List<ModelsLib.PatientDetails>();
            for (int i = 0; i < lines.Count; i++)
            {
                ModelsLib.PatientDetails _isntance = MapLineItemToPatientObject(lines[i]);
                _patientsList.Add(_isntance);
            }
            return _patientsList;
        }
        private List<String> GetALLLines(string path)
        {
            System.IO.StreamReader _reader = new System.IO.StreamReader(path);
            List<string> lines = new List<string>();
            while (!_reader.EndOfStream)
            {
                string pathLines = _reader.ReadLine();
                lines.Add(pathLines);
            }
            _reader.Close();
            return lines;
        }
        
        private ModelsLib.PatientDetails MapLineItemToPatientObject(string lineItem)
        {
            string[] lineItem1 = lineItem.Split(',');
            ModelsLib.PatientDetails _patientDetails = new ModelsLib.PatientDetails();
            _patientDetails.Name = lineItem1[0];
            _patientDetails.height = Convert.ToDouble(lineItem1[1]);
            _patientDetails.weight = Convert.ToDouble(lineItem1[2]);
                return _patientDetails;

        }
        
    }
}
