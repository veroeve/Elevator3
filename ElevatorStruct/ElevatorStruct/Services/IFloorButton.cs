using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    interface IFloorButton
    {
        void HideButton(Button button);
        void ShowButton(Button button);

    }
}
