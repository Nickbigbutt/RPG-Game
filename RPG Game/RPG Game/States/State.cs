using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    internal class State
    {
        Stack<State> states;

        public State(Stack<State> states) 
        {

            this.states = states;


           // Console.WriteLine(this.states.GetHashCode());
        
        }
    }
}
