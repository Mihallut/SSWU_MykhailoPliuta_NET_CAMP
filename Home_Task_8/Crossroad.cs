using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_Task_8.Strategies;
using Home_Task_8.TrafficLights;

namespace Home_Task_8
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
            _workSeconds = workSeconds > 0 ? workSeconds : 1;
            DefineStrategy();
        }

        private void DefineStrategy()
        {
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
            else if (_strategy is BigXShapedCrossraodStrategy)
            {
                BigXShapedCrossraodStrategy bigXShaped = (BigXShapedCrossraodStrategy)_strategy;
                foreach (TrafficLight trafficLight in _trafficlights)
                {
                    if (trafficLight is TrafficLightForTurn)
                    {
                        if (trafficLight.location.ToString().Contains("West"))
                        {
                            bigXShaped.WestEastChangeColorLeft += trafficLight.ChangeColor;
                            bigXShaped.WestEastYellowLeft += trafficLight.SetYellow;
                        }
                        else
                        {
                            bigXShaped.NorthSouthChangeColorLeft += trafficLight.ChangeColor;
                            bigXShaped.NorthSouthYellowLeft += trafficLight.SetYellow;
                        }
                    }
                    else if (trafficLight is TrafficLightWithTurn)
                    {
                        TrafficLightWithTurn trafficLightWithTurn = (TrafficLightWithTurn)trafficLight;
                        if (trafficLight.location.ToString().Contains("West"))
                        {
                            bigXShaped.WestEastYellowStraight += trafficLightWithTurn.SetYellow;
                            bigXShaped.WestEastYellowRight += trafficLightWithTurn.SetTurnYellow;
                            bigXShaped.WestEastChangeColorStraight += trafficLightWithTurn.ChangeColor;
                            bigXShaped.WestEastChangeColorRight += trafficLightWithTurn.ChangeTurnColor;
                        }
                        else
                        {
                            bigXShaped.NorthSouthYellowStraight += trafficLightWithTurn.SetYellow;
                            bigXShaped.NorthSouthYellowRight += trafficLightWithTurn.SetTurnYellow;
                            bigXShaped.NorthSouthChangeColorStraight += trafficLightWithTurn.ChangeColor;
                            bigXShaped.NorthSouthChangeColorRight += trafficLightWithTurn.ChangeTurnColor;
                        }
                    }
                    else
                    {
                        if (trafficLight.location.ToString().Contains("West"))
                        {
                            bigXShaped.WestEastYellowStraight += trafficLight.SetYellow;
                            bigXShaped.WestEastChangeColorStraight += trafficLight.ChangeColor;
                        }
                        else
                        {
                            bigXShaped.NorthSouthYellowStraight += trafficLight.SetYellow;
                            bigXShaped.NorthSouthChangeColorStraight += trafficLight.ChangeColor;
                        }
                    }
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
