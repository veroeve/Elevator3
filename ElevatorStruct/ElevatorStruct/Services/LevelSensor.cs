using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{

    class LevelSensor : ILevelSensor
    {
        IReviewer _reviewer;
        public void NotifyArrival(TextBox txtElevator, int currentFloor)
        {
            _reviewer = new Reviewer();
            IObserver obsMotor = new Motor(txtElevator);
            IObserver obsFloorDoor = new FloorDoor(txtElevator);
            IObserver obsCabinDoor = new CabinDoor(txtElevator);
            _reviewer.LevelHaveRequest += new Notify(obsMotor.Notify);
            _reviewer.LevelHaveRequest += new Notify(obsFloorDoor.Notify);
            _reviewer.LevelHaveRequest += new Notify(obsCabinDoor.Notify);
            _reviewer.HaveRequest(currentFloor);
        }
    }
}
