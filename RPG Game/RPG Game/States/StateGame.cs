using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
     class StateGame : State
    {

        public StateGame(Stack<State> states) : base(states)
        {
            Console.WriteLine("Hello from the game state");
        }


    }
}
