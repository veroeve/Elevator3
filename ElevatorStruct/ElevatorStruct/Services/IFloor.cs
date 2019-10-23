using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    interface IFloor
    {
        void CreateButton(Direction nameButton, Button button);
        void CreateLevel(int numberLevel,int heightLevel,LevelType type);
        void CreateDisplay(Label display);
        int GetLevel(ICabin cabin);
        void ShowLevel(int Level);
    }
}
