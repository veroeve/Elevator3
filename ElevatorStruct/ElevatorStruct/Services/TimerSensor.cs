using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ElevatorStruct.Services
{
    class TimerSensor:ITimerSensor
    {
        DispatcherTimer dispathcer = new DispatcherTimer();
        public void Star(IElevator elevator)
        {

            dispathcer.Interval = new TimeSpan(0, 0, 3);
            dispathcer.Tick += (s, a) =>
            {
                elevator.MoveElevator();
            };
            dispathcer.Start();
        }
    }
}
