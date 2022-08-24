using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class Game
    {
        public int DieRoll()
        {
            Random random = new Random();
            random.Next(1, 7);
            return dieCount;

        }
    }
}
