using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_2
{
    internal class WaterTower
    {
        private readonly double _maxWaterLevel;

        private double _currentWaterLevel;

        private Pump _pump;

        public Pump Pump
        {
            get { return (Pump)_pump.Clone(); }
            set { _pump = (Pump)value.Clone(); }
        }

        public double CurrentWaterLevel { get { return _currentWaterLevel; } }

        public WaterTower(double maxWaterLevel, Pump pump)
        {
            this._maxWaterLevel = maxWaterLevel;
            _pump = pump;
        }

        public double GiveAwayWater(double requirement)
        {

            return 0;
        }

        public void PumpWater()
        {


        }

        public override string ToString()
        {

            return $"Water Tower Info:\n 1. Max water level = {_maxWaterLevel}\n 2. Current water level = {_currentWaterLevel}\n 3. {_pump.ToString()}";
        }



    }
}
