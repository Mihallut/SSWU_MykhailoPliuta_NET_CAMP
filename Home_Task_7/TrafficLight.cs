using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_Task_7.Enums;

namespace Home_Task_7
{
    public class TrafficLight
    {
        private Colors _currentColor;
        private Colors _colorBeforeChange;

        public readonly Locations location;
        public event Action ColorWasChanged;
        public Colors CurrentColor { get { return _currentColor; } }

        public TrafficLight(Locations location, bool isStartColorGreen)
        {
            _currentColor = isStartColorGreen ? Colors.Green : Colors.Red;
            _colorBeforeChange = _currentColor;
            this.location = location;
        }

        public void SetYellow()
        {
            _colorBeforeChange = _currentColor;
            _currentColor = Colors.Yellow;
            ColorWasChanged?.Invoke();
        }

        public void ChangeColor()
        {
            _currentColor = _colorBeforeChange == Colors.Green ? Colors.Red : Colors.Green;
            ColorWasChanged?.Invoke();
        }
    }
}
