using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_7.Strategies
{
    public class XShapedCrossroadStrategy : ICrossroadStrategy
    {
        private int _greenColorLightTime;
        private int _redColorLightTime;
        public int GreenColorLightTime { get { return _greenColorLightTime; } set { if (value > 0) { _greenColorLightTime = value; } } }
        public int RedColorLightTime { get { return _redColorLightTime; } set { if (value > 0) { _redColorLightTime = value; } } }
        public event Action TheeSecondsBeforeChangeColor;
        public event Action ChangeColor;


        public XShapedCrossroadStrategy(int greenColorLightTime, int redColorLightTime)
        {
            _greenColorLightTime = greenColorLightTime;
            _redColorLightTime = redColorLightTime;
        }


        public void MenageCrossoradTrafficLights()
        {
            Thread.Sleep(GreenColorLightTime * 1000 - 3000);
            TheeSecondsBeforeChangeColor?.Invoke();
            Thread.Sleep(3000);
            ChangeColor?.Invoke();
            Thread.Sleep(RedColorLightTime * 1000 - 3000);
            TheeSecondsBeforeChangeColor?.Invoke();
            Thread.Sleep(3000);
            ChangeColor?.Invoke();
        }
    }
}
