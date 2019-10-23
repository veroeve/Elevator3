using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    public delegate void Notify(string numberFloor);
    class LevelSensor
    {
        private string _numberFloor;

        public event Notify floorChange;
        public void Change(string numberFloor)
        {
            _numberFloor = numberFloor;

            if (floorChange != null)
            {
                floorChange.Invoke(_numberFloor);
            }

        }
    }
}
