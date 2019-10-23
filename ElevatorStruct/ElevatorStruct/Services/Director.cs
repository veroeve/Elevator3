using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorStruct.Enums;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    class Director : IDirector
    {
        Direction _elevatorDirection = Direction.none;        
        IRequestManager _requestManager= new RequestManager();
        IMotionSensor _motionSensor = new MotionSensor();
        IDirectionManager _directionManager = new DirectionManager();
        ILevelSensor _levelSensor = new LevelSensor();
        ITimerSensor _timerSensor = new TimerSensor();
        int _currentLevel;        
        TextBox _txtElevator;
        
        public Director(TextBox txtElevator)
        {
            _txtElevator = txtElevator;
        }
        public void CreateRequest(int numberFloor, Direction requestDirection)
        {
            EnsureCurrentDirection(requestDirection);
            _requestManager.CreateRequest(numberFloor,requestDirection);
        }
        private void EnsureCurrentDirection(Direction requestDirection)
        {
            if (_elevatorDirection == Direction.none)
            {
                _elevatorDirection = requestDirection;
            }
        }

        public void MoveElevator(IMotor motor, ICabin cabin, IFloor floor)
        {
            if(_requestManager.HasAnyRequest())
            {
                DoorState tempstate = cabin.GetDoorState();
                if(tempstate == DoorState.open)
                {
                    _timerSensor.Stop();
                    cabin.UpdateDoorState(DoorState.close);
                    floor.UpdateDoorState(DoorState.close);
                }
                _elevatorDirection = _directionManager.EnsureDirection(_currentLevel,_elevatorDirection, _requestManager);
                _motionSensor.MoveCabin(motor, cabin, _elevatorDirection);
                _currentLevel = floor.GetLevel(cabin);
                cabin.ShowLevel(_currentLevel);
                floor.ShowLevel(_currentLevel);
                if(_requestManager.FloorHaveRequest(_currentLevel,_elevatorDirection))
                {
                    _levelSensor.NotifyArrival(_txtElevator, _currentLevel);
                }
            }
    
        }
    
    }
}
