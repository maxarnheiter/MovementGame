using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame
{
    //Just an X and Y Position object
    public class Position
    {
        int _x;
        int _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
