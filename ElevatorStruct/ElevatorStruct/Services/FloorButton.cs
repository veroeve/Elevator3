using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    class FloorButton:IFloorButton 
    {
        LevelType _direction;
        Button _button;
        public LevelType direction
        {
            get { return _direction; }
            set { value = _direction; }

        }
        public Button button
        {
            get { return _button; }
            set { value = _button; }

        }
        public FloorButton(LevelType direction=LevelType.both, Button button=null)
        {
            _direction = direction;
            _button = button;
        }
        public void HideButton(Button button)
        {
            button.Visibility = Visibility.Hidden;
        }

        public void ShowButton(Button button)
        {
            button.Visibility = Visibility.Visible;
        }
    }
}
