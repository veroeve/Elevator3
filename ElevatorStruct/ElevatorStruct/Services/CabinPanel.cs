using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    class CabinPanel:ICabinPanel 
    {
        List<CabinButton> _cabinButtons = new List<CabinButton>();
        ICabinButton _cabinButton = new CabinButton();
        public void CreateButton(string nameButton, Button button)
        {
            _cabinButtons.Add(new CabinButton(nameButton, button));
        }

        public void TurnOffCabinButtonForFloor(string numberfloor)
        {
            foreach (var item in _cabinButtons)
            {
                if (item.name == numberfloor)
                {
                    _cabinButton.ChangeColor(item.button);
                }
            }
        }
    }
}
