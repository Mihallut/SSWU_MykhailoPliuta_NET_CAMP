using Home_Task_8.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_8.TrafficLights
{
    public class TrafficLightForTurn : TrafficLight
    {
        public readonly Turns turn;
        public TrafficLightForTurn(Locations location, Turns turn, bool isStartColorGreen) : base(location, isStartColorGreen)
        {
            this.turn = turn;
        }
    }
}
