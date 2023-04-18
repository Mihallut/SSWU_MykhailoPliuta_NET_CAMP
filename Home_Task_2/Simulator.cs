using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_2
{
    internal class Simulator
    {

        private WaterTower _waterTower;


        public Simulator(WaterTower waterTower)
        {
            _waterTower = waterTower;
        }

        public void ProcessUser(User user)
        {

        }
        // Який метод викликатиме цей?
        private bool IsWaterLevelEnough(double requirement)
        {
            return true;
        }

        public override string ToString()
        {
            return $"Simulator info: \n Water tower:\n{_waterTower.ToString()}";
        }

    }
}
