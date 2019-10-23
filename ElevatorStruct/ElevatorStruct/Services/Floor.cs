using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ElevatorStruct.Enums;

namespace ElevatorStruct.Services
{
    class Floor : IFloor
    {
        List<FloorButton> _floorButtons = new List<FloorButton>();
        List<int> _pointers = new List<int>();
        List<FloorLevel> _floorLevels = new List<FloorLevel>();
        FloorDisplay _floorDisplay;
        TextBox _txtElevator;
        int total = 0;
        public Floor(TextBox txtElevator)
        {
            _txtElevator = txtElevator;
        }
        public void CreateButton(Direction direction, Button button)
        {
            _floorButtons.Add(new FloorButton(direction, button));

        }

        public void CreateDisplay(Label display)
        {
            _floorDisplay = new FloorDisplay(display);
        }

        public void CreateLevel(int numberLevel, int heightLevel, LevelType type)
        {
            _floorLevels.Add(new FloorLevel(numberLevel, heightLevel, type));
            _pointers.Add(total + heightLevel);
        }
    
        public int GetLevel(ICabin cabin)
        {
            int totals = 0;
            int level = 0;
            int cabinHeight = cabin.GetHeight();
            foreach (var item in _floorLevels)
            {
                totals = totals + item.heightLevel;
                if (totals < cabinHeight)
                {
                    level = item.numberLevel;
                }
            }
            return level;
        }
        public void ShowLevel(int Level)
        {
            _floorDisplay.display.Content = Level;
        }

    }
}
