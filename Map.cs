using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame
{
    public static class Map
    {
        static int _width;
        public static int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        static int _height;
        public static int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        //Check to see if the new position is within the size of the map
        public static bool IsPositionValid(Position position)
        {
            if (position.X >= 0 && position.X < Width)
            if (position.Y >= 0 && position.Y < Height)
                    return true;

            Console.WriteLine("Oops, new Player Position would be outside the map.");
            return false;
        }
    }
}
