using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ElevatorStruct.Services
{
    class CabinButton:ICabinButton
    {

        string _name;
        Button _button;

        public string name
        {
            get { return _name; }
            set { value = _name; }

        }
        public Button button
        {
            get { return _button; }
            set { value = _button; }

        }
        public CabinButton(string name="", Button button=null)
        {
            _name = name;
            _button = button;
        }

        public void ChangeColor(Button button)
        {
            var bc = new BrushConverter();
            button.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
        }
    }
}
