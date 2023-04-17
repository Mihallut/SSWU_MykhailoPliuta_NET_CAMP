using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3
{
    public static class Display
    {


        public static void PrintReportForApartment(Apartment apartment, double costOfKW)
        {
            int maxAddressLength = apartment.Address.Length + "Address".Length;
            int maxNumberLength = apartment.Number.ToString().Length + "No.".Length;
            int maxOwnerLastnameLength = apartment.OwnerLastname.Length + "Owner".Length;
            int maxInputValueLength = apartment.InputValue.ToString().Length + "Input".Length;
            int maxOutputValueLength = apartment.OutputValue.ToString().Length + "Output".Length;
            int maxInspectionDatesLength = apartment.InspactionDatesInStringFormat.ToString().Length + "Inspection dates".Length;
            int maxDebtLenght = apartment.CalculateAmountOfExpenses(costOfKW).ToString().Length + "Debt".Length;
            int maxDaysFromLastInspection = apartment.DaysFromLastInspection.ToString().Length + "Days".Length;



            string format = "{0,-" + maxAddressLength + "} {1,-" + maxNumberLength + "} {2,-" + maxOwnerLastnameLength + "} {3,-" + maxInputValueLength + "} {4,-" + maxOutputValueLength + "} {5,-" + maxDebtLenght + "} {6,-" + maxInspectionDatesLength + "} {7,-" + maxDaysFromLastInspection + "}";
            Console.WriteLine(string.Format(format, "Address", "No.", "Owner", "Input", "Output", "Debt", "Inspection dates", "Days"));

            Console.WriteLine(string.Format(format,
                                    apartment.Address,
                                    apartment.Number,
                                    apartment.OwnerLastname,
                                    apartment.InputValue,
                                    apartment.OutputValue,
                                    apartment.CalculateAmountOfExpenses(costOfKW),
                                    apartment.InspactionDatesInStringFormat,
                                    apartment.DaysFromLastInspection));
        }

        public static void PrintReportForAll(DataAnalyzer da)
        {

            int iterator = 1;
            foreach (List<Apartment> quoter in da.Quaters)
            {
                Console.WriteLine("Quoter" + iterator);
                iterator++;
                int maxAddressLength = quoter.Max(a => a.Address.Length) + "Address".Length;
                int maxNumberLength = quoter.Max(a => a.Number.ToString().Length) + "No.".Length;
                int maxOwnerLastnameLength = quoter.Max(a => a.OwnerLastname.Length) + "Owner".Length;
                int maxInputValueLength = quoter.Max(a => a.InputValue.ToString().Length) + "Input".Length;
                int maxOutputValueLength = quoter.Max(a => a.OutputValue.ToString().Length) + "Output".Length;
                int maxInspectionDatesLength = quoter.Max(a => a.InspactionDatesInStringFormat.ToString().Length) + "Inspection dates".Length;
                int maxDebtLenght = quoter.Max(a => a.CalculateAmountOfExpenses(da.costOfKW).ToString().Length) + "Debt".Length;
                int maxDaysFromLastInspection = quoter.Max(a => a.DaysFromLastInspection.ToString().Length) + "Days".Length;

                string format = "{0,-" + maxAddressLength + "} {1,-" + maxNumberLength + "} {2,-" + maxOwnerLastnameLength + "} {3,-" + maxInputValueLength + "} {4,-" + maxOutputValueLength + "} {5,-" + maxDebtLenght + "} {6,-" + maxInspectionDatesLength + "} {7,-" + maxDaysFromLastInspection + "}";
                Console.WriteLine(string.Format(format, "Address", "No.", "Owner", "Input", "Output", "Debt", "Inspection dates", "Days"));
                foreach (Apartment apartment in quoter)
                {

                    Console.WriteLine(string.Format(format,
                        apartment.Address,
                        apartment.Number,
                        apartment.OwnerLastname,
                        apartment.InputValue,
                        apartment.OutputValue,
                        apartment.CalculateAmountOfExpenses(da.costOfKW),
                        apartment.InspactionDatesInStringFormat,
                        apartment.DaysFromLastInspection));

                }
                Console.WriteLine();
            }
        }
    }
}
