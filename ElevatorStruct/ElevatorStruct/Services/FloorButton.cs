using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    class FloorButton
    {
        Direction _direction;
        Button _button;
        public FloorButton(Direction direction, Button button)
        {
            _direction = direction;
            _button = button;
        }
    }
}
