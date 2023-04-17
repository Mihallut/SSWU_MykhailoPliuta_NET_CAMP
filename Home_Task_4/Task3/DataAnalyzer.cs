using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3
{
    public class DataAnalyzer
    {
        private List<List<Apartment>> _quaters;
        public readonly double costOfKW;

        public List<List<Apartment>> Quaters { get { return _quaters; } }
        public DataAnalyzer(List<List<Apartment>> quaters, double costOfKW)
        {
            _quaters = quaters;
            this.costOfKW = costOfKW;
        }

        public Apartment GetApartment(int number, string address)
        {
            foreach (List<Apartment> quater in _quaters)
            {

                foreach (Apartment apartment in quater)
                {
                    if (apartment.Address.Equals(address) && apartment.Number == number)
                    {
                        return apartment;
                    }
                }
            }
            return null;
        }

        public Apartment FindInactiveApartment()
        {
            foreach (List<Apartment> quater in _quaters)
            {

                foreach (Apartment apartment in quater)
                {
                    if (apartment.InputValue == apartment.OutputValue)
                    {
                        return apartment;
                    }
                }
            }
            return null;
        }

        public string GetBiggestDebtOwner()
        {
            string lastname = "";
            double theBiggestDebt = 0;
            foreach (List<Apartment> quater in _quaters)
            {

                foreach (Apartment apartment in quater)
                {
                    double currentDebt = apartment.CalculateAmountOfExpenses(costOfKW);
                    if (theBiggestDebt < currentDebt)
                    {
                        theBiggestDebt = currentDebt;
                        lastname = apartment.OwnerLastname;
                    }
                }
            }

            return lastname;
        }

    }
}
