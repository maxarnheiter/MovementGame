using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame
{
    public static class Conf
    {

        //Player Constants
        static Position _PLAYER_START_POSITION;
        public static Position PLAYER_START_POSITION
        {
            get
            {
                if (_PLAYER_START_POSITION == null)
                    _PLAYER_START_POSITION = new Position(0, 0);

                return _PLAYER_START_POSITION;
            }
        }

        //Map Constants
        public const int MAP_WIDTH = 5;
        public const int MAP_HEIGHT = 5;
    }
}
