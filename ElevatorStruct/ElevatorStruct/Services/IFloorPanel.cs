using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    interface IFloorPanel
    {
        void CreateButton(LevelType direction, Button button);
        void ChangeButtonStatus(LevelType type);
    }
}
