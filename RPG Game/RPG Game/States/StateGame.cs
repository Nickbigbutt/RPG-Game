using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
     class StateGame : State
    {

        protected Character character;

        public StateGame(Stack<State> states, Character activecharacter) : base(states)
        {
            this.character = activecharacter;
        }



        public void ProcressInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    Console.WriteLine(this.character.ToStringBanner());
                    break;
                default:
                    break;
            }
        }



        override public void Update()
        {


            Gui.MenuTitle("Game State");
            Gui.MenuOption(1, "Character stats");
            Gui.MenuOption(-1, "exit");


            Gui.GetInput("Input: ");
            int input = Gui.GetInputInt("Input: ");


            this.ProcressInput(input);

        }



    }
}
