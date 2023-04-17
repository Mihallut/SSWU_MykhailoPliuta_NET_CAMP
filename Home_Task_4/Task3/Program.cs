
namespace Task3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            double costOfCW = 1.44;
            string path = @"C:\Users\Mik\source\repos\111_Sigma\HW\Home_Task_4\Task3\InputData.txt";
            DataAnalyzer da = new DataAnalyzer(DataDeserializer.Deserialize(path), costOfCW);
            Display.PrintReportForAll(da);
            Console.WriteLine();
            Console.WriteLine("Get apartnemt by address and number:");
            Display.PrintReportForApartment(da.GetApartment(2, "qwerty"), costOfCW);
            Console.WriteLine();
            Console.WriteLine("Get the biggest debt owner lastname:");
            Console.WriteLine(da.GetBiggestDebtOwner());
            Console.WriteLine();
            Console.WriteLine("Find inactive apartment");
            Display.PrintReportForApartment(da.FindInactiveApartment(), costOfCW);


        }
    }
}