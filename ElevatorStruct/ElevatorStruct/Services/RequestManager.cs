using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorStruct.Enums;

namespace ElevatorStruct.Services
{
    class RequestManager : IRequestManager
    {
        List<Request> _toGoUpRequests = new List<Request>();
        List<Request> _toGoDownRequests = new List<Request>();
        List<Request> _cabinRequests = new List<Request>();
      
        public void CreateRequest(int numberFloor, Direction requestDirection)
        {
            if (requestDirection == Direction.up)
            {
                _toGoUpRequests.Add(new Request(numberFloor, requestDirection));
            }
            else if (requestDirection == Direction.down)
            {
                _toGoDownRequests.Add(new Request(numberFloor, requestDirection));
            }
            else if (requestDirection == Direction.none)
            {
                _cabinRequests.Add(new Request(numberFloor, requestDirection));
            }
        }
        public bool HasAnyRequest()
        {
            if (_toGoDownRequests.Count > 0)
            {
                return true;
            }
            if (_toGoUpRequests.Count > 0)
            {
                return true;
            }
            if (_cabinRequests.Count > 0)
            {
                return true;
            }

            return false;
        }
     
        public bool FloorHaveRequest(int currentLevel, Direction elevatorDirection)
        {
            bool islevel = false;
            if (elevatorDirection == Direction.up)
            {
                islevel= IsOnLevel(_toGoUpRequests , currentLevel);
            }
            else
            {
                islevel= IsOnLevel(_toGoDownRequests , currentLevel);
            }
            if(!islevel)
            {
                islevel = IsOnLevel(_cabinRequests, currentLevel);
            }

            return islevel;
        }
        private bool IsOnLevel(List<Request> TempRequests, int currentLevel)
        {
            foreach (var item in TempRequests)
            {
                if (item.numberFloor == currentLevel)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Request> GetUpRequests()
        {
            return _toGoUpRequests;
        }
        public List<Request> GetDownRequests()
        {
            return _toGoDownRequests;
        }

        public void DeleteRequest()
        {
            throw new NotImplementedException();
        }


    }
}
