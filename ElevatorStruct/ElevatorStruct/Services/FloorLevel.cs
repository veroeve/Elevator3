using ElevatorStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorStruct.Services
{
    class FloorLevel
    {
        int _numberLevel;
        int _heightLevel;
        LevelType _type;
        public int heightLevel
        {
            get { return _heightLevel; }
            set { value = _heightLevel; }

        }
        public LevelType type
        {
            get { return _type; }
            set { value = _type; }

        }
        public int numberLevel
        {
            get { return _numberLevel; }
            set { value = _numberLevel; }

        }
        public FloorLevel(int numberLevel, int heightLevel, LevelType type)
        {
            _numberLevel = numberLevel;
            _heightLevel = heightLevel;
            _type = type;
        }
    }
}
