using Home_Task_8.Enums;
using Home_Task_8.Strategies;
using Home_Task_8.TrafficLights;
using System.Text;

namespace Home_Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            Crossroad crossroad = new Crossroad(
              new List<TrafficLight>
              {
                        new TrafficLightForTurn(Locations.NorthSouthLeft, Turns.Left, false),
                        new TrafficLight(Locations.NorthSouth, false),
                        new TrafficLightWithTurn(Locations.NorthSouthRight, Turns.Right, false, false),
                        new TrafficLightForTurn(Locations.SouthNorthLeft, Turns.Left, false),
                        new TrafficLight(Locations.SouthNorth, false),
                        new TrafficLightWithTurn(Locations.SouthNorthRight, Turns.Right, false, false),
                        new TrafficLightForTurn(Locations.WestEastLeft, Turns.Left, false),
                        new TrafficLight(Locations.WestEast, true),
                        new TrafficLightWithTurn(Locations.WestEastRight, Turns.Right, true, true),
                        new TrafficLightForTurn(Locations.EastWestLeft, Turns.Left, false),
                        new TrafficLight(Locations.EastWest, true),
                        new TrafficLightWithTurn(Locations.EastWestRight, Turns.Right, true, true),

              },
              new BigXShapedCrossraodStrategy(3, 10, 10, 10, 10),
              Display.GetWorkSeconds());

            crossroad.ConditionWasChanged += Display.DisplayInfoForBigXShaped;
            crossroad.Run();

        }
    }
}