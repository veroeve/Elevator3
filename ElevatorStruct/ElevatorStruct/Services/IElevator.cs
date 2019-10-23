using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    interface IElevator
    {
        void CreateCabinButton(Dictionary<string, Button> dictionaryButton);
        void CreateFloorButton(Dictionary<Enums.LevelType, Button> dictionaryButton);
        void CreateLevel(int numberLevel, int hightLevel, LevelType type);
        void CreateDisplay(Label lblDisplayFloor,Label lblDisplayCabin);
        void CreateRequest(int numberRequest, Direction requestDirection);
        void MoveElevator();
        void ChangeLevelButtonStatus(int numberLevel);
    }
}
