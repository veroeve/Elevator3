using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    interface IRequestManager
    {
        void CreateRequest(int numberFloor, Direction direction);
        bool FloorHaveRequest(int currentLevel, Direction elevatorDirection);
        bool HasAnyRequest();
        List<Request> GetUpRequests();
        List<Request> GetDownRequests();

    }
}
