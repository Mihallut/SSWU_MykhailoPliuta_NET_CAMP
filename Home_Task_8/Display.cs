using Home_Task_8.Enums;
using Home_Task_8.TrafficLights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_8
{
    public static class Display
    {

        public static int GetColorLightTime(string trafficlightLocation, string colorName)
        {
            Console.WriteLine($"Enter {colorName} color light time for {trafficlightLocation} traffic light:");
            return int.Parse(Console.ReadLine());
        }

        public static int GetWorkSeconds()
        {
            Console.WriteLine("Enter crossroad work seconds for demo:");
            return int.Parse(Console.ReadLine());
        }


        public static void DisplayInfo(CrossroadEventArgs args)
        {
            Console.Clear();

            string[] headers = new string[args.TrafficLights.Count + 1];
            headers[0] = "Traffic Light";
            for (int i = 0; i < args.TrafficLights.Count; i++)
            {
                headers[i + 1] = args.TrafficLights[i].location.ToString();
            }

            string[] colors = new string[args.TrafficLights.Count + 1];
            colors[0] = "Colors";
            for (int i = 0; i < args.TrafficLights.Count; i++)
            {
                colors[i + 1] = args.TrafficLights[i].CurrentColor.ToString();
            }

            int maxLength = headers.Max(h => h.Length);
            maxLength = Math.Max(maxLength, colors.Max(c => c.Length + 1));

            for (int i = 0; i < headers.Length; i++)
            {
                Console.Write(headers[i].PadRight(maxLength));
                if (i < headers.Length - 1)
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i].PadRight(maxLength));
                if (i < colors.Length - 1)
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();

        }

        public static void DisplayInfoForBigXShaped(CrossroadEventArgs args)
        {
            Console.Clear();

            Console.WriteLine("              │    |    |    │    |    |    │");
            Console.WriteLine("              │    |    |    │    |    |    │");
            Console.WriteLine("              │    |    |    │    |    |    │");
            Console.WriteLine("              │    |    |    │    |    |    │");
            Console.WriteLine("              │    |    |    │    |    |    │");
            Console.Write("              │ ");
            DefineArrowColors(args.TrafficLights, Locations.NorthSouthRight);
            Console.Write(" |  ");
            DefineArrowColors(args.TrafficLights, Locations.NorthSouth);
            Console.Write(" |  ");
            DefineArrowColors(args.TrafficLights, Locations.NorthSouthLeft);
            Console.Write(" │    |    |    │              \n");
            Console.WriteLine("──────────────┘                             └──────────────");
            Console.Write("                                             ");
            DefineArrowColors(args.TrafficLights, Locations.EastWestRight);
            Console.Write("            \n");
            Console.WriteLine("−−−−−−−−−−−−−−                               −−−−−−−−−−−−−−");
            Console.Write("                                             ");
            DefineArrowColors(args.TrafficLights, Locations.EastWest);
            Console.Write("             \n");
            Console.WriteLine("−−−−−−−−−−−−−−                               −−−−−−−−−−−−−−");
            Console.Write("                                             ");
            DefineArrowColors(args.TrafficLights, Locations.EastWestLeft);
            Console.Write("            \n");
            Console.WriteLine("──────────────                               ──────────────");
            Console.Write("             ");
            DefineArrowColors(args.TrafficLights, Locations.WestEastLeft);
            Console.Write("                                             \n");
            Console.WriteLine("−−−−−−−−−−−−−−                               −−−−−−−−−−−−−−");
            Console.Write("             ");
            DefineArrowColors(args.TrafficLights, Locations.WestEast);
            Console.Write("                                             \n");
            Console.WriteLine("−−−−−−−−−−−−−−                               −−−−−−−−−−−−−−");
            Console.Write("            ");
            DefineArrowColors(args.TrafficLights, Locations.WestEastRight);
            Console.Write("                                             \n");
            Console.WriteLine("──────────────┐                             ┌──────────────");
            Console.Write("              │    |    |    │  ");
            DefineArrowColors(args.TrafficLights, Locations.SouthNorthLeft);
            Console.Write(" |  ");
            DefineArrowColors(args.TrafficLights, Locations.SouthNorth);
            Console.Write(" | ");
            DefineArrowColors(args.TrafficLights, Locations.SouthNorthRight);
            Console.Write(" │\n");
            Console.WriteLine("              │    |    |    │    |    |    │");
            Console.WriteLine("              │    |    |    │    |    |    │");
            Console.WriteLine("              │    |    |    │    |    |    │");
            Console.WriteLine("              │    |    |    │    |    |    │");
            Console.WriteLine("              │    |    |    │    |    |    │");
        }

        private static void DefineArrowColors(List<TrafficLight> trafficLights, Locations location)
        {
            foreach (TrafficLight tr in trafficLights)
            {
                if (location == tr.location)
                {
                    Console.ForegroundColor = (ConsoleColor)tr.CurrentColor;
                    switch (location)
                    {
                        case Locations.SouthNorth:
                            Console.Write("↑");
                            break;

                        case Locations.SouthNorthLeft:
                            Console.Write("←");
                            break;

                        case Locations.SouthNorthRight:
                            Console.Write("↑");
                            Console.ResetColor();
                            TrafficLightWithTurn trwt = (TrafficLightWithTurn)tr;
                            Console.ForegroundColor = (ConsoleColor)trwt.CurrentTurnColor;
                            Console.Write("→");
                            break;
                        case Locations.NorthSouth:
                            Console.Write("↓");
                            break;

                        case Locations.NorthSouthLeft:
                            Console.Write("→");
                            break;

                        case Locations.NorthSouthRight:
                            TrafficLightWithTurn trwt1 = (TrafficLightWithTurn)tr;
                            Console.ForegroundColor = (ConsoleColor)trwt1.CurrentTurnColor;
                            Console.Write("←");
                            Console.ResetColor();
                            Console.ForegroundColor = (ConsoleColor)trwt1.CurrentColor;
                            Console.Write("↓");
                            break;
                        case Locations.WestEast:
                            Console.Write("→");
                            break;

                        case Locations.WestEastLeft:
                            Console.Write("↑");
                            break;

                        case Locations.WestEastRight:
                            TrafficLightWithTurn trwt2 = (TrafficLightWithTurn)tr;
                            Console.ForegroundColor = (ConsoleColor)trwt2.CurrentTurnColor;
                            Console.Write("↓");
                            Console.ResetColor();
                            Console.ForegroundColor = (ConsoleColor)trwt2.CurrentColor;
                            Console.Write("→");
                            break;
                        case Locations.EastWest:
                            Console.Write("←");
                            break;

                        case Locations.EastWestLeft:
                            Console.Write("↓");
                            break;

                        case Locations.EastWestRight:
                            Console.Write("←");
                            Console.ResetColor();
                            TrafficLightWithTurn trwt3 = (TrafficLightWithTurn)tr;
                            Console.ForegroundColor = (ConsoleColor)trwt3.CurrentTurnColor;
                            Console.Write("↑");
                            break;
                    }
                    Console.ResetColor();
                }
            }

        }
    }
}
