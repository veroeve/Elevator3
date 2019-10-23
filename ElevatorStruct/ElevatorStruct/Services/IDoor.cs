using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    interface IDoor
    {
        void Close(int numberFloor);
        void Open(int numberFloor);
        DoorState GetDoorState();
        void UpdateDoorState(DoorState state);
    }
}
