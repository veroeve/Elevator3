using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    class CabinButton
    {

        string _name;
        Button _button;
        public CabinButton(string name, Button button)
        {
            _name = name;
            _button = button;
        }
    }
}
