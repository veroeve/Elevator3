using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    interface ICabin
    {
        void CreateCabinButton(string nameButton, Button button);
        void CreateDisplay(Label display);
        void UpdateHeight(int height);
        int GetHeight();
        void ShowLevel(int Level);
        DoorState GetDoorState();
        void UpdateDoorState(DoorState state);
        void changeColorCabinButton(string numberfloor);
    }
}
