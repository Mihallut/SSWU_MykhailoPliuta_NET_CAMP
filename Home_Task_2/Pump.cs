using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_2
{
    internal class Pump : ICloneable
    {
        private readonly double _power;

        private bool _isOn = false;

        public bool IsOn
        {
            get { return _isOn; }
        }

        public Pump(double power)
        {
            _power = power;
        }

        public void ChangeState()
        {
            _isOn = _isOn ? false : true;
        }


        public object Clone()
        {
            return new Pump(_power);
        }

        public override string ToString()
        {
            return $"Pump power = {_power}";
        }
    }
}
