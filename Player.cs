using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame
{
    //A delegate to handle movement events
    public delegate void MoveEventHandler(MoveEventArgs args);

    public static class Player
    {
        static Position _position;

        public static Position Position
        {
            get { return _position; }
            set { _position = value; }
        }

        //A move event
        public static event MoveEventHandler Move;

        //The move function we call from outside
        public static void OnMove(MoveEventArgs args)
        {
            var handler = Move;
            if (handler != null)
                handler(args);
        }
    }

    //Our custom event args class to hold movement information
    public class MoveEventArgs : EventArgs
    {
        int _xChange;
        public int XChange
        {
            get { return _xChange; }
        }

        int _yChange;
        public int YChange
        {
            get { return _yChange; }
        }

        Position _startPosition;
        public Position StartPosition
        {
            get { return _startPosition; }
        }

        public MoveEventArgs(int xChange, int yChange, Position startPosition)
        {
            this._xChange = xChange;
            this._yChange = yChange;
            this._startPosition = startPosition;
        }
    }
}
