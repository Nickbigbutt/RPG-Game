using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{





    class StateCharacterCreator : State
    {


        //Varriables
        ArrayList characterList;



        //Private function
        private void createCharacter()
        {
            String name = "";
            Gui.GetInput("Input character name: ");
            name = Console.ReadLine();



            this.characterList.Add(new Character(name));

            Gui.Announcement("Character created");
        }

        public StateCharacterCreator(Stack<State> states, ArrayList character_List) : base(states)
        {
            this.characterList = character_List;
        }


        public void ProcressInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    this.createCharacter();
                    break;
                default:
                    break;
            }
        }





        override public void Update()
        {


            Gui.MenuTitle("Character creator");
            Gui.MenuOption(1, "New Character");
            Gui.MenuOption(2, "Edit Character");
            Gui.MenuOption(3, "Delete Character");
            Gui.MenuOption(-1, "exit");


            
            int input = Gui.GetInputInt("Input: ");


            this.ProcressInput(input);

        }



    }
}
