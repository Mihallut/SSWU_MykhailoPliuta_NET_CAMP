using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Apartment
    {
        private string _address;
        private int _number;
        private string _ownerLastname;
        private double _inputValue;
        private double _outputValue;
        private DateTime[] _inspectionDates = new DateTime[3];
        private int _daysFromLastInspection;


        public string Address { get { return _address; } }
        public int Number { get { return _number; } }
        public string OwnerLastname { get { return _ownerLastname; } }
        public double InputValue { get { return _inputValue; } }
        public double OutputValue { get { return _outputValue; } }
        public DateTime[] InspectionDates { get { return _inspectionDates; } }
        public int DaysFromLastInspection { get { return _daysFromLastInspection; } }
        public string InspactionDatesInStringFormat
        {
            get
            {
                string result = "";
                for (int i = 0; i < _inspectionDates.Length; i++)
                {
                    result += $"{_inspectionDates[i].ToString("MMMM/dd/yyyy")} ";
                }
                return result;
            }
        }


        public Apartment(string address, int number, string ownerLastname, double inputValue, double outputValue, DateTime[] inspectionDates)
        {
            _address = address;
            _number = number;
            _ownerLastname = ownerLastname;
            _inputValue = inputValue;
            _outputValue = outputValue;
            _inspectionDates = inspectionDates;
            _daysFromLastInspection = DateTime.Now.Subtract(inspectionDates[inspectionDates.Length - 1]).Days;
        }

        public double CalculateAmountOfExpenses(double costOfKW)
        {
            return (_outputValue - _inputValue) * costOfKW;
        }
    }
}
