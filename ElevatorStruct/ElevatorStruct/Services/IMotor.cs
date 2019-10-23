using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    interface IMotor
    {
        int MotorUp(int cabinheight);
        int MotorDown(int cabinheight);
        void Stop(string numberFloor);
    }
}
