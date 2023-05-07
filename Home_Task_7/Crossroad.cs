using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_Task_7.Strategies;

namespace Home_Task_7
{
    public class Crossroad
    {
        private ICrossroadStrategy _strategy;
        private List<TrafficLight> _trafficlights;
        private int _workSeconds;
        public delegate void CrossroadEventHandler(CrossroadEventArgs args);
        public event CrossroadEventHandler ConditionWasChanged;

        public Crossroad(List<TrafficLight> trafficLights, ICrossroadStrategy crossroadStrategy, int workSeconds)
        {
            _trafficlights = new(trafficLights);
            _strategy = crossroadStrategy;
            _workSeconds = workSeconds;

            if (_strategy is XShapedCrossroadStrategy)
            {
                XShapedCrossroadStrategy xShaped = (XShapedCrossroadStrategy)_strategy;
                foreach (TrafficLight trafficLight in _trafficlights)
                {
                    xShaped.TheeSecondsBeforeChangeColor += trafficLight.SetYellow;
                    xShaped.ChangeColor += trafficLight.ChangeColor;
                    trafficLight.ColorWasChanged += SomethingWasChanged;
                }
            }
        }

        public void Run()
        {
            ConditionWasChanged?.Invoke(new CrossroadEventArgs(new List<TrafficLight>(_trafficlights)));

            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < _workSeconds * 1000)
            {
                _strategy.MenageCrossoradTrafficLights();
            }
        }

        private void SomethingWasChanged()
        {
            if (_trafficlights.Any())
            {
                ConditionWasChanged?.Invoke(new CrossroadEventArgs(new List<TrafficLight>(_trafficlights)));
            }
        }
    }
}
