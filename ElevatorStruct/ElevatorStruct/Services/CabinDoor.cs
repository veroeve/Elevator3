using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    class CabinDoor : IDoor, IObserver 
    {
        DoorState _state;
        TextBox _txtElevator;
        public DoorState state
        {
            get { return _state; }
            set { value = _state; }

        }
        public CabinDoor(TextBox text)
        {
            _txtElevator = text;
            _state = DoorState.close;
        }
        public void Close(int numberFloor)
        {
            _txtElevator.AppendText($"Closing cabin door on level {numberFloor} \r\n");
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
            _txtElevator.AppendText($"Opening  cabin door on level {numberFloor} \r\n");
            _state = DoorState.open;
        }

        public void UpdateDoorState(DoorState state)
        {
            _state = state;
        }
    }
}
