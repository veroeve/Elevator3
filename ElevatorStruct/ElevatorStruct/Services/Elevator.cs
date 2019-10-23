using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElevatorStruct.Services
{
    class Elevator:IElevator
    {
        TextBox _txtElevator;
        ICabin _cabin;
        IFloor _floor;
        IDirector _director;
        IMotor _motor;
        
        public Elevator(TextBox txtElevator)
        {
            _txtElevator = txtElevator;
            _cabin = new Cabin(txtElevator, 0);
            _floor = new Floor(txtElevator);
            _director = new Director(txtElevator);
            _motor = new Motor(txtElevator);
        }

        public void CreateCabinButton(Dictionary<string, Button> dictionaryButton)
        {
            foreach (var button in dictionaryButton)
            {
                _cabin.CreateButton(button.Key, button.Value);
            }
        }

        public void CreateFloorButton(Dictionary<Enums.LevelType, Button> dictionaryButton)
        {
            foreach (var button in dictionaryButton)
            {
                _floor.CreateButton(button.Key, button.Value);
            }
        }

        public void CreateLevel(int numberLevel, int hightLevel, LevelType type)
        {
            _floor.CreateLevel(numberLevel, hightLevel, type);
        }

        public void CreateDisplay(Label lblDisplayFloor, Label lblDisplayCabin)
        {
            _cabin.CreateDisplay(lblDisplayCabin);
            _floor.CreateDisplay(lblDisplayFloor);
        }

        public void CreateRequest(int numberRequest, Direction requestDirection)
        {
           _director.CreateRequest(numberRequest, requestDirection);
        }

        public void MoveElevator()
        {
            _director.MoveElevator(_motor,_cabin,_floor);

        }
        public void ChangeLevelButtonStatus(int numberLevel)
        {
            _floor.ChangeButtonStatus(numberLevel);
        }
    }
}
