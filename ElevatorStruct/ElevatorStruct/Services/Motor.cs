using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    class Motor:IMotor,IObserver
    {
        TextBox _txtElevator;
        public Motor(TextBox txtElevator)
        {
            _txtElevator = txtElevator;
        }

        public int MotorDown(int cabinheight)
        {
            cabinheight--;
            _txtElevator.AppendText("Motor going down \r\n");
            return cabinheight;
        }

        public int MotorUp(int cabinheight)
        {
            cabinheight++;
            _txtElevator.AppendText("Motor going up \r\n");
            return cabinheight;
        }

        public void Notify(int numberFloor)
        {
            Stop(numberFloor);
        }

        public void Stop(int numberFloor)
        {
            _txtElevator.AppendText($"Motor Stopped on the floor:{numberFloor} \r\n");
        }
    }
}
