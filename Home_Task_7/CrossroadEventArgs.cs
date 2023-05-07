using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_7
{
    public class CrossroadEventArgs : EventArgs
    {
        private List<TrafficLight> _trafficLights;
        public List<TrafficLight> TrafficLights { get { return _trafficLights; } }
        public CrossroadEventArgs(List<TrafficLight> trafficLights)
        {
            _trafficLights = trafficLights;
        }
    }
}
