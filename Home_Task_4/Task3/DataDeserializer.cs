using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class DataDeserializer
    {


        public static List<List<Apartment>> Deserialize(string path)
        {
            List<List<Apartment>> quaters = new List<List<Apartment>>();
            StreamReader sr = new StreamReader(path);
            string line;
            line = sr.ReadLine();
            while (!String.IsNullOrEmpty(line))
            {
                if (line.Contains("Amount of flats:"))
                {
                    List<Apartment> quater = DeserializeQuater(sr, ref line);
                    quaters.Add(quater);
                    line = sr.ReadLine();
                }

            }
            return quaters;

        }

        private static List<Apartment> DeserializeQuater(StreamReader sr, ref string line)
        {
            List<Apartment> quater = new List<Apartment>();
            while (!String.IsNullOrEmpty(line))
            {
                line = sr.ReadLine();
                if (!String.IsNullOrEmpty(line))
                {
                    string[] apartmentData = line.Split("; ", StringSplitOptions.RemoveEmptyEntries);
                    string address = null;
                    int number = 0;
                    string ownerLastname = null;
                    double inputValue = 0;
                    double outputValue = 0;
                    DateTime[] inspectionDates = new DateTime[3];
                    for (int i = 0; i < apartmentData.Length; i++)
                    {
                        string value = GetStringValue(apartmentData, i); ;
                        if (apartmentData[i].StartsWith("Apartment number"))
                        {
                            number = int.Parse(value);
                        }
                        else if (apartmentData[i].StartsWith("Address"))
                        {
                            address = value;
                        }
                        else if (apartmentData[i].StartsWith("Lastname"))
                        {
                            ownerLastname = value;
                        }
                        else if (apartmentData[i].StartsWith("input"))
                        {
                            inputValue = Double.Parse(value);
                        }
                        else if (apartmentData[i].StartsWith("output"))
                        {
                            outputValue = Double.Parse(value);
                        }
                        else if (apartmentData[i].StartsWith("Check Dates"))
                        {
                            string[] dates = value.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                            for (int j = 0; j < inspectionDates.Length; j++)
                            {
                                string[] str = dates[j].Split(".", StringSplitOptions.RemoveEmptyEntries);

                                inspectionDates[j] = new DateTime(int.Parse(str[2]), int.Parse(str[1]), int.Parse(str[0]));
                            }
                        }
                    }
                    Apartment apartment = new Apartment(address, number, ownerLastname, inputValue, outputValue, inspectionDates);
                    quater.Add(apartment);
                }
            }

            return quater;
        }


        private static string GetStringValue(string[] apartmentData, int i)
        {

            List<string> strings = apartmentData[i].Split(": ", StringSplitOptions.RemoveEmptyEntries).ToList();
            return strings[strings.Count - 1];
        }
    }
}
