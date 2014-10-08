using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Program by Max Arnheiter
 * 
 * This program is an exercise in learning C#, specifically event, delegates, and event args.
 * Everything but Positions are static. This simplifies things since all of those things exist 
 * only once, and that means we don't have to write some kind of resource manager, or worry too 
 * much about passing information. 
 * 
 * This program could (and might) be expanded to include the following features:
 *      - it could display a character-based map that shows where the player is and how large the map is
 *              - it could include some events to have the game end if the player 'falls' off the map.
 *      - it could be changed so that the map is non-static and the game asks the user for the map size
 *      - it could include any number of other event-managed-systems
 *      - it could have all actions handled as events, such as:
 *              - inital game setup
 *              - passing user input as event args
 *              - asking the map if the position is valid could be an event
 *              - etc.
 */

namespace MovementGame
{
    class Game
    {
        static void Main(string[] args)
        {
            //Set the Map Width
            Map.Width = Conf.MAP_WIDTH;
            Map.Height = Conf.MAP_HEIGHT;

            //Set the Player Position
            Player.Position = Conf.PLAYER_START_POSITION;
           
            //Set Movement to listen to Player Events
            Movement.SubscribeToPlayer();

            //Inform the user about input options, and how to exit
            Console.WriteLine("Enter either w,a,s,d to move, or x to quit. Enjoy!");

            //Continously Process Input
            ProcessInput();

        }

        static void ProcessInput()
        {
            char input;

            //Grab input while true
            while ((input = Console.ReadKey().KeyChar) != 'x' || input != 'X')
            {
                Console.Write(" -> ");
                switch (input)
                {
                    case 'w': case 'W':   //Up
                        {
                            Player.OnMove(new MoveEventArgs(0, 1, Player.Position));
                            break;
                        }
                    case 'a': case 'A':  //Left
                        {
                            Player.OnMove(new MoveEventArgs(-1, 0, Player.Position));
                            break;
                        }
                    case 's': case 'S':   //Down
                        {
                            Player.OnMove(new MoveEventArgs(0, -1, Player.Position));
                            break;
                        }
                    case 'd': case 'D':   //Right
                        {
                            Player.OnMove(new MoveEventArgs(1, 0, Player.Position));
                            break;
                        }
                }
            }
        }
    }
}
