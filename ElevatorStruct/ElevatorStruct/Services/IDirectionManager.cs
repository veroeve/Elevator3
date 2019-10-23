using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    interface IDirectionManager
    {
        Direction EnsureDirection(int currentFloor, Direction elevatorDirection,IRequestManager requestManager);
    }
}
