using ElevatorStruct.Enums;
using ElevatorStruct.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ElevatorStruct
{  
    public partial class MainWindow : Window
    {
        IElevator _elevator;
        ITimerSensor _timeSensor = new TimerSensor();
        Dictionary<Enums.LevelType, Button> _dictionaryFloorButton = new Dictionary<Enums.LevelType, Button>();
        Dictionary<string, Button> _dictionaryCabinButton = new Dictionary<string, Button>();
        public MainWindow()
        {
            InitializeComponent();
            txtElevator.AppendText("Start \r\n");
            CreateFloorButton();
            CreateCabinButton();
            _elevator = new Elevator(txtElevator);
            _elevator.CreateFloorButton(_dictionaryFloorButton);
            _elevator.CreateCabinButton(_dictionaryCabinButton);
            CreateLevels();
            _elevator.CreateDisplay(lblDisplayFloor, lblDisplayCabin);
            _timeSensor.Star(_elevator);
            cmbFloor.SelectionChanged += selection;

        }
        private void selection(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFloor.SelectedValue == null)
            {
                MessageBox.Show($"Select a floor");
                return;
            }
            else
            {
                int numberLevel = (int)cmbFloor.SelectedValue;
               _elevator.ChangeLevelButtonStatus(numberLevel);
            }
        }
        public void CreateFloorButton()
        {
            _dictionaryFloorButton.Add(LevelType.up, btnUp);
            _dictionaryFloorButton.Add(LevelType.down, btnDown);
        }       
        public void CreateCabinButton()
        {
            var floorQuantity = int.Parse(ConfigurationSettings.AppSettings["floorQuantity"]);
            for (int i = 0; i < floorQuantity; i++)
            {
                var btn = new Button();
                btn.Content = "Floor " + i;
                btn.Tag = i;
                btn.Click += btn0_Click;
                btn.Height = 39;
                if (i % 2 == 0)
                {
                    pnlOdd.Children.Add(btn);
                }
                else
                {
                    pnlEven.Children.Add(btn);
                }
                _dictionaryCabinButton.Add(i.ToString(), btn);
            }

        }       
        public void CreateLevels()
        {
            var floorQuantity = int.Parse(ConfigurationSettings.AppSettings["floorQuantity"]);
            for (int i = 0; i < floorQuantity; i++)
            {
                string key = "Floor" + i;
                var type = LevelType.both;
                // Do: Fill combobox
                cmbFloor.Items.Add(i);
                // Do: Create virtual floors                
                if (i == 0)
                {
                    type = LevelType.up;
                }
                if (i == floorQuantity - 1)
                {
                    type = LevelType.down;
                }
                if (ConfigurationSettings.AppSettings[key] != null)
                {
                    _elevator.CreateLevel(i, Int32.Parse(ConfigurationSettings.AppSettings[key]), type);
                }
            }
        }
        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            var buttonClicked = sender as Button;
            if (cmbFloor.SelectedValue == null)
            {
                MessageBox.Show($"Select a floor");
                return;
            }
            Enums.Direction direction = (Enums.Direction)Enum.Parse(typeof(Enums.Direction), buttonClicked.Tag.ToString());
            int numberFloor = (int)cmbFloor.SelectedValue;
            _elevator.CreateRequest(numberFloor, direction);
        }
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            var buttonClicked = sender as Button;
            buttonClicked.Background = Brushes.Red;
            txtElevator.AppendText($"Floor request {buttonClicked.Tag.ToString()} \r\n");
            _elevator.CreateRequest(int.Parse(buttonClicked.Tag.ToString()), Direction.none);
        }
    }
}
