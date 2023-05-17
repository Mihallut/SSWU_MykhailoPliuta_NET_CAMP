using Home_Task_7.Enums;
using Home_Task_7.Strategies;

namespace Home_Task_7
{// Ваш бал 98.
    internal class Program
    {
        static void Main(string[] args)
        {

            Crossroad crossroad = new Crossroad(
              new List<TrafficLight>
              {
                        new TrafficLight(Enums.Locations.NorthSouth, true),
                        new TrafficLight(Enums.Locations.EastWest, false) ,
                        new TrafficLight(Enums.Locations.SouthNorth, true) ,
                        new TrafficLight(Enums.Locations.WestEast, false)
              },
              new XShapedCrossroadStrategy(Display.GetColorLightTime("NorthSouth/SouthNorth", "green"), Display.GetColorLightTime("EastWest/WestEast", "green")),
              Display.GetWorkSeconds());


            crossroad.ConditionWasChanged += Display.DisplayInfo;
            crossroad.Run();
        }
    }
}
