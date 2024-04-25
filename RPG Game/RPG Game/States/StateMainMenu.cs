using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
     class StateMainMenu : State
    {

        protected ArrayList characterList;
        protected Character activeCharacter;

        public StateMainMenu(Stack<State> states, ArrayList character_List) : base(states)
        {

            this.characterList = character_List;
            this.activeCharacter = null;

        }
        


        public void ProcressInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    this.StartNewGame();
                    break;
                case 2:
                    this.states.Push(new StateCharacterCreator(this.states, this.characterList));
                    break;
                case 3:
                    this.SelectCharacter();
                    
                    break;
                default:
                    break;
            }
        }


        override public void Update()
        {
            if (this.activeCharacter != null)
            {
                Console.WriteLine(this.activeCharacter.ToStringBanner() + "\n");
                
            }
            


            Gui.MenuTitle("Main Menu");
            Gui.MenuOption(1, "New Game");
            Gui.MenuOption(2, "Character creator");
            Gui.MenuOption(3, "Select Character");
            Gui.MenuOption(-1, "exit");




            
            int input = Gui.GetInputInt("Input");

           

            this.ProcressInput(input);

        }


        public void StartNewGame()
        {
            // While active character variable in null you cannot start the game.
            if (this.activeCharacter == null) //error
            {
                Gui.Error("There is no character selected, please select one before starting the game");
            }
            else //start game
            {
                this.states.Push(new StateGame(this.states, this.activeCharacter));
            }
        }


        public void SelectCharacter()
        {

            //print all selectable characters
             for (int i = 0; i < this.characterList.Count; i++)
            {
                Console.WriteLine(i + ": " + characterList[i].ToString());
            }

            int choice = Gui.GetInputInt("Character selection");


          try
            {
                this.activeCharacter = (Character)this.characterList[choice];
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            if (this.activeCharacter != null)
                Gui.Announcement($"The character {this.activeCharacter.ToString()} is selected. ");

        }


    }
}
