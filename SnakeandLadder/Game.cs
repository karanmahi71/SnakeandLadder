using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class Game
    {
        public void Play()
        {
            int option = random.Next(0, 3);
            switch (option)
            {
                case No_PLAY: playerPosition += 0;
                    break;
                case LADDER: playerPosition += DieRoll();
                    break;
                case SNAKE:  playerPosition -= DieRoll();
                    break;
            }
            Console.WriteLine(playerPosition);
        }
    }
}
