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
        IFloorPanel _floorPanel = new FloorPanel();       
        List<FloorLevel> _floorLevels = new List<FloorLevel>();
        FloorDisplay _floorDisplay;
        IDoor _floorDoor;     
        TextBox _txtElevator;
        public Floor(TextBox txtElevator)
        {
            _txtElevator = txtElevator;
            _floorDoor = new FloorDoor(_txtElevator);
        }
        public void CreateButton(LevelType direction, Button button)
        {
            _floorPanel.CreateButton(direction, button);
        }

        public void CreateDisplay(Label display)
        {
            _floorDisplay = new FloorDisplay(display);
        }

        public void CreateLevel(int numberLevel, int heightLevel, LevelType type)
        {
            _floorLevels.Add(new FloorLevel(numberLevel, heightLevel, type));
           
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
        public void UpdateDoorState(DoorState state)
        {
            _floorDoor.UpdateDoorState(state);
        }
        public void ChangeButtonStatus(int numberLevel)
        {
            foreach(var item in _floorLevels)
            {
                if(item.numberLevel== numberLevel)
                {
                    _floorPanel.ChangeButtonStatus(item.type);
                }
            }           
        }
    }
}
