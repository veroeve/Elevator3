using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorStruct.Enums;

namespace ElevatorStruct.Services
{
    class DirectionManager : IDirectionManager
    {
        public Direction EnsureDirection(int currentFloor, Direction elevatorDirection, IRequestManager requestManager)
        {
            if (elevatorDirection == Direction.up)
            {
                return ChangeUpDirection(currentFloor, requestManager.GetUpRequests());
            }
            else
            {
                return ChangeDownDirection(currentFloor, requestManager.GetDownRequests());
            }
        }
        private Direction ChangeUpDirection(int currentFloor, List<Request> toGoUpRequests)
        {
            if (toGoUpRequests.Count > 0)
            {
                if (toGoUpRequests.Exists(c => c.numberFloor > currentFloor))
                {
                    return Direction.up;
                }
                else
                {
                    return Direction.down;
                }
            }
            else
            {
                return Direction.down;
            }
        }
        private Direction ChangeDownDirection(int currentFloor, List<Request> toGoDownRequests)
        {
            if (toGoDownRequests.Count > 0)
            {
                if (toGoDownRequests.Exists(c => c.numberFloor < currentFloor))
                {
                    return Direction.down;
                }
                else
                {
                    return Direction.up;
                }
            }
            else
            {
                return Direction.up;
            }
        }
    }
}
