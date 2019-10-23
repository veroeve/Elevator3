using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    class Request
    {
        int _numberFloor;
        Direction _direction;
        public int numberFloor
        {
            get { return _numberFloor; }
            set { value = _numberFloor; }

        }
        public Request(int numberFloor, Direction direction)
        {
            _numberFloor = numberFloor;
            _direction = direction;
        }
    }
}
