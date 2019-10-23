using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    interface IDirector
    {
        void CreateRequest(int numberFloor,Direction requestDirection);
        void MoveElevator(IMotor motor, ICabin cabin, IFloor floor);
    }
}
