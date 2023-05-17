using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_Task_8.Enums;

namespace Home_Task_8.TrafficLights
{
    public class TrafficLight
    {
        protected Colors _currentColor;
        protected Colors _colorBeforeChange;

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
            InvokeColorWasChangedEvent();
        }
        protected void InvokeColorWasChangedEvent()
        {
            ColorWasChanged?.Invoke();
        }
        public void ChangeColor()
        {
            _currentColor = _colorBeforeChange == Colors.Green ? Colors.Red : Colors.Green;
            InvokeColorWasChangedEvent();
        }
    }
}
