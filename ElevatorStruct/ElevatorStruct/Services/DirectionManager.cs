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
                return ChangeUpDirection(currentFloor, requestManager.GetUpRequests(),requestManager);
            }
            else
            {
                return ChangeDownDirection(currentFloor, requestManager.GetDownRequests(), requestManager);
            }
        }
        private Direction ChangeUpDirection(int currentFloor, List<Request> toGoUpRequests, IRequestManager requestManager)
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
                if(requestManager.GetDownRequests().Count>0)
                {
                    return ChangeDownDirection( currentFloor, requestManager.GetDownRequests(), requestManager);
                }

                return Direction.down;
            }
        }
        private Direction ChangeDownDirection(int currentFloor, List<Request> toGoDownRequests, IRequestManager requestManager)
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
                if(requestManager.GetUpRequests().Count > 0)
                {
                    return ChangeUpDirection(currentFloor, requestManager.GetUpRequests(), requestManager);
                }
                return Direction.up;
            }
        }
    }
}
