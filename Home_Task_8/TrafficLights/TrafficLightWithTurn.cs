using Home_Task_8.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_8.TrafficLights
{
    public class TrafficLightWithTurn : TrafficLight
    {

        private Colors _currentTurnCollor;
        private Colors _turnCollorBeforeChange;
        public readonly Turns turn;
        public Colors CurrentTurnColor { get { return _currentTurnCollor; } }


        public TrafficLightWithTurn(Locations location, Turns turn, bool isStartColorGreen, bool isTurnStartColorGreen) : base(location, isStartColorGreen)
        {
            _currentTurnCollor = isTurnStartColorGreen ? Colors.Green : Colors.Red;
            _turnCollorBeforeChange = _currentTurnCollor;
            this.turn = turn;
        }


        public void SetTurnYellow()
        {
            _turnCollorBeforeChange = _currentTurnCollor;
            _currentTurnCollor = Colors.Yellow;
            InvokeColorWasChangedEvent();
        }

        public void ChangeTurnColor()
        {
            _currentTurnCollor = _turnCollorBeforeChange == Colors.Green ? Colors.Red : Colors.Green;
            InvokeColorWasChangedEvent();
        }
    }
}
