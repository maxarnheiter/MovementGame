using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame
{
    public static class Movement
    {
        //Listen to player events
        public static void SubscribeToPlayer()
        {
            Player.Move += Player_Move;
        }

        //Handle player movement event
        public static void Player_Move(MoveEventArgs args)
        {
            //Create a new position based off the arguments passed in
            Position newPosition = new Position(args.StartPosition.X + args.XChange, args.StartPosition.Y + args.YChange);

            //Ask the map if the position is valid
            if(Map.IsPositionValid(newPosition))
            {
                //Set the new player position
                Player.Position = newPosition;

                //Inform the user of the change
                Console.WriteLine("Success! New Player Position is : " + Player.Position.X + "," + Player.Position.Y);
            }
        }

    }
}
