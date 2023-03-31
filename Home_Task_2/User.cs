using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_2
{
    internal class User
    {
        private double _requirement;

        private double _received = 0;

        private bool _isRequirmentSatisfied = false;

        public double Requirement { get { return _requirement; } }
        public double Received { get { return _received; } }
        public bool IsRequirmentSatisfied { get { return _isRequirmentSatisfied; } }

        public User(int requirement)
        {
            _requirement = requirement;
        }

        public void GetWaterFromTower(WaterTower waterTower)
        {

        }

        public override string ToString()
        {
            return $"User info:\n 1. Requirement = {_requirement} \n 2. Received = {_received} \n 3. Is requirement satisfied = {_isRequirmentSatisfied}";
        }

    }
}
