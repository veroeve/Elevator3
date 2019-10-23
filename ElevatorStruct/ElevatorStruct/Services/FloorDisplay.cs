using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    class FloorDisplay
    {
        Label _display;
        public Label display
        {
            get { return _display; }
            set { value = _display; }

        }
        public FloorDisplay(Label display)
        {
            _display = display;
        }
    }
}
