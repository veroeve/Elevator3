using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    class FloorPanel:IFloorPanel
    {
        List<FloorButton> _floorButtons = new List<FloorButton>();
        IFloorButton _floorButton= new FloorButton();
        public void CreateButton(LevelType direction, Button button)
        {
            _floorButtons.Add(new FloorButton(direction, button));

        }
       
        public void ChangeButtonStatus(LevelType type)
        {
            if(LevelType.up==type)
            {
                ShowButton(LevelType.up);
                HideButton(LevelType.down);
            }
            if (LevelType.down == type)
            {
                ShowButton(LevelType.down);
                HideButton(LevelType.up);
                
            }
            if (LevelType.both == type)
            {
                ShowButton(LevelType.down);
                ShowButton(LevelType.up);
            }
        }
        private void ShowButton(LevelType type)
        {
            foreach(var item in _floorButtons)
            {
                if(item.direction==type)
                {
                    _floorButton.ShowButton(item.button);
                }
            }          
        }

        private void HideButton(LevelType type)
        {
            foreach (var item in _floorButtons)
            {
                if (item.direction == type)
                {
                    _floorButton.HideButton(item.button);
                }
            }
        }
    }
}
