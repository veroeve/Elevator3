using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    interface ILevelSensor
    {
        event Notify stateChange;
        void Change(string state);
    }
}
