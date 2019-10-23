using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    public delegate void Notify(int numberFloor);
    
    class Reviewer : IReviewer
    {
        private int _numberFloor;
        public event Notify LevelHaveRequest;

        public void HaveRequest(int numberFloor)
        {
            _numberFloor = numberFloor;
            if (LevelHaveRequest != null)
            {
                LevelHaveRequest.Invoke(_numberFloor);
            }
        }
    }
}
