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
    
        public int GetLevel(ICabin cabin, Direction elevatorDirecion, int currentFloor)
        {
            int cabinHeight = cabin.GetHeight();
            int heightFloor = getfloorheigth(currentFloor);
            if (elevatorDirecion == Direction.up)
            {
                currentFloor = GoUp(cabin, heightFloor, cabinHeight, currentFloor);               
            }
            else
            {
                currentFloor = GoDown(cabin,cabinHeight, currentFloor);
                          
            } 
            return currentFloor;
        }

        private int getfloorheigth(int currentFloor)
        {
            foreach(var item in _floorLevels)
            {
                if(item.numberLevel==currentFloor)
                {
                    return item.heightLevel;
                }
            }
            return 0;
        }
        private int GoUp(ICabin cabin,int heightFloor, int cabinHeight, int currentFloor)
        {
            if (cabinHeight > heightFloor)
            {
                cabin.UpdateHeight(0);
                return currentFloor = currentFloor + 1;               
            }
            return currentFloor;
        }
        private int  GoDown(ICabin cabin,int cabinHeight, int currentFloor)
        {
            if (cabinHeight < 0)
            {
                cabin.UpdateHeight(getfloorheigth(currentFloor));
                return currentFloor = currentFloor - 1;                
            }
            return currentFloor;
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
