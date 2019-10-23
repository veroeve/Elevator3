﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    interface ITimerSensor
    {
        void Star(IElevator elevator);
        void Stop();
    }
}
