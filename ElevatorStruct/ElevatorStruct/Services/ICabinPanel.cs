using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    interface ICabinPanel
    {
        void CreateButton(string nameButton, Button button);
        void TurnOffCabinButtonForFloor(string numberfloor);
    }
}
