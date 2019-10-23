using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    class MotionSensor:IMotionSensor
    {
        public void MoveCabin(IMotor motor, ICabin cabin, Direction elevatorDirection)
        {
            if (elevatorDirection == Direction.up)
            {
                cabin.UpdateHeight(motor.MotorUp(cabin.GetHeight()));
            }
            else
            {
                cabin.UpdateHeight(motor.MotorDown(cabin.GetHeight()));
            }
        }
    }
}
