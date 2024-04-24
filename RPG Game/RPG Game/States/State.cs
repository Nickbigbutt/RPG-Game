using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    internal class State
    {
        protected Stack<State> states;
        protected bool end = false;

        public State(Stack<State> states) 
        {

            this.states = states;
           // Console.WriteLine(this.states.GetHashCode());
        }

        public bool RequestEnd()
        {
            return this.end;
        }


        virtual public void Update() 
        {
        
        }

    }
}
