using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ElevatorStruct.Enums;

namespace ElevatorStruct.Services
{
    public class Cabin : ICabin
    {
        ICabinPanel _cabinPanel = new  CabinPanel();
        CabinDisplay _cabinDisplay;
        IDoor _cabinDoor;
        TextBox _txtElevator;
        int _cabinHeight;
        public Cabin(TextBox txtElevator, int height)
        {
            _txtElevator = txtElevator;
            _cabinHeight = height;
            _cabinDoor = new CabinDoor(_txtElevator);
        }
        public void CreateCabinButton(string nameButton, Button button)
        {
            _cabinPanel.CreateButton(nameButton, button);
        }
        public void CreateDisplay(Label display)
        {
            _cabinDisplay = new CabinDisplay(display);
        }

        public void UpdateHeight(int height)
        {
            _cabinHeight = height;
        }

        public int GetHeight()
        {
            return _cabinHeight;
        }
        public void ShowLevel(int Level)
        {
            _cabinDisplay.display.Content = Level;
        }

        public DoorState GetDoorState()
        {
           return _cabinDoor.GetDoorState();
           
        }

        public void UpdateDoorState(DoorState state)
        {
            _cabinDoor.UpdateDoorState(state);
        }

        public void changeColorCabinButton(string numberfloor)
        {
            _cabinPanel.TurnOffCabinButtonForFloor(numberfloor);
        }
    }
}
