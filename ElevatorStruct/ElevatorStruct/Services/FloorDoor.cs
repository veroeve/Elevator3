using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    class FloorDoor : IDoor, IObserver 
    {
        DoorState _state;
        TextBox _txtElevator;
        public FloorDoor(TextBox text)
        {
            _txtElevator = text;
        }
        public void Close(int numberFloor)
        {
            _txtElevator.AppendText($"Closing level {numberFloor} door \r\n");
            _state = DoorState.close;
        }

        public DoorState GetDoorState()
        {
            return _state;
        }

        public void Notify(int numberFloor)
        {
            Open(numberFloor);
        }

        public void Open(int numberFloor)
        {
            _txtElevator.AppendText($"Opening level {numberFloor} door \r\n");
            _state = DoorState.open;
        }
        public void UpdateDoorState(DoorState state)
        {
            _state = state;
            if(_state==DoorState.close)
            {
                _txtElevator.AppendText($"Closing level door \r\n");
            }
            else
            {
                _txtElevator.AppendText($"Opening level door \r\n");
            }
            
        }
    }
}
