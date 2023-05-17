using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_8.Strategies
{
    public class BigXShapedCrossraodStrategy : ICrossroadStrategy
    {
        #region West-East events
        public event Action WestEastChangeColorStraight;
        public event Action WestEastChangeColorLeft;
        public event Action WestEastChangeColorRight;

        public event Action WestEastYellowStraight;
        public event Action WestEastYellowLeft;
        public event Action WestEastYellowRight;
        #endregion

        #region North-South events
        public event Action NorthSouthChangeColorStraight;
        public event Action NorthSouthChangeColorLeft;
        public event Action NorthSouthChangeColorRight;

        public event Action NorthSouthYellowStraight;
        public event Action NorthSouthYellowLeft;
        public event Action NorthSouthYellowRight;
        #endregion

        private int _yellowTime;
        private int _westEastGreenStraightTime;
        private int _westEastLeftAndRightTime;
        private int _northSouthGreenStraightTime;
        private int _northSouthLeftAndRightTime;

        #region Properties
        public int YellowTime
        {
            get { return _yellowTime / 1000; }
            set { if (value > 0) { _yellowTime = value * 1000; } }
        }
        public int WestEastGreenStraightTime
        {
            get { return _westEastGreenStraightTime / 1000; }
            set { if (value > 0) { _westEastGreenStraightTime = value * 1000; } }
        }
        public int WestEastLeftAndRightTime
        {
            get { return _westEastLeftAndRightTime / 1000; }
            set { if (value > 0) { _westEastLeftAndRightTime = value * 1000; } }
        }
        public int NorthSouthGreenStraightTime
        {
            get { return _northSouthGreenStraightTime / 1000; }
            set { if (value > 0) { _northSouthGreenStraightTime = value * 1000; } }
        }
        public int NorthSouthLeftAndRightTime
        {
            get { return _northSouthLeftAndRightTime / 1000; }
            set { if (value > 0) { _northSouthLeftAndRightTime = value * 1000; } }
        }
        #endregion

        public BigXShapedCrossraodStrategy(int yellowTime, int westEastGreenStraightTime, int westEastLeftAndRightTime, int northSouthGreenStraightTime, int northSouthLeftAndRightTime)
        {
            _yellowTime = yellowTime > 0 ? yellowTime * 1000 : 3;
            _westEastGreenStraightTime = westEastGreenStraightTime > 0 ? (westEastGreenStraightTime - yellowTime > 0 ? westEastGreenStraightTime * 1000 : yellowTime + 1000) : 10000;
            _westEastLeftAndRightTime = westEastLeftAndRightTime > 0 ? (westEastLeftAndRightTime - yellowTime > 0 ? westEastLeftAndRightTime * 1000 : yellowTime + 1000) : 10000;
            _northSouthGreenStraightTime = northSouthGreenStraightTime > 0 ? (northSouthGreenStraightTime - yellowTime > 0 ? northSouthGreenStraightTime * 1000 : yellowTime + 1000) : 10000;
            _northSouthLeftAndRightTime = northSouthLeftAndRightTime > 0 ? (northSouthLeftAndRightTime - yellowTime > 0 ? northSouthLeftAndRightTime * 1000 : yellowTime + 1000) : 10000;
        }

        public void MenageCrossoradTrafficLights()
        {
            Thread.Sleep(_westEastGreenStraightTime - _yellowTime);
            WestEastYellowStraight?.Invoke();
            WestEastYellowLeft?.Invoke();

            Thread.Sleep(_yellowTime);
            WestEastChangeColorStraight?.Invoke();
            WestEastChangeColorLeft?.Invoke();

            Thread.Sleep(_westEastLeftAndRightTime - _yellowTime);
            WestEastYellowRight?.Invoke();
            WestEastYellowLeft?.Invoke();

            Thread.Sleep(_yellowTime);
            WestEastChangeColorLeft?.Invoke();
            WestEastChangeColorRight?.Invoke();
            NorthSouthYellowStraight?.Invoke();
            NorthSouthYellowRight?.Invoke();

            Thread.Sleep(_yellowTime);
            NorthSouthChangeColorStraight?.Invoke();
            NorthSouthChangeColorRight?.Invoke();

            Thread.Sleep(_northSouthGreenStraightTime - _yellowTime);
            NorthSouthYellowStraight?.Invoke();
            NorthSouthYellowLeft?.Invoke();

            Thread.Sleep(_yellowTime);
            NorthSouthChangeColorStraight?.Invoke();
            NorthSouthChangeColorLeft?.Invoke();

            Thread.Sleep(_northSouthLeftAndRightTime - _yellowTime);
            NorthSouthYellowRight?.Invoke();
            NorthSouthYellowLeft?.Invoke();

            Thread.Sleep(_yellowTime);
            NorthSouthChangeColorLeft?.Invoke();
            NorthSouthChangeColorRight?.Invoke();
            WestEastYellowStraight?.Invoke();
            WestEastYellowRight?.Invoke();

            Thread.Sleep(_yellowTime);
            WestEastChangeColorStraight?.Invoke();
            WestEastChangeColorRight?.Invoke();
        }

    }
}
