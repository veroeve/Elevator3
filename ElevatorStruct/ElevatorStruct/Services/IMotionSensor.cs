using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    interface IMotionSensor
    {
        void MoveCabin(IMotor motor, ICabin cabin, Direction elevatorDirection);
    }
}
