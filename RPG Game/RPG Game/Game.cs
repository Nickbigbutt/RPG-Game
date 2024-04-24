using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    internal class Game
    {

        //Variable
        private bool end;

        public bool End
        {
            get { return this.end; }
            set { this.end = value; }
        }

        private Gui gui;

        private Stack<State> states;

        //private functians
        private void InitVariables()
        {
            this.end = false;
        }

        private void InitStates()
        {
            this.states = new Stack<State>();

            //Console.WriteLine(this.states.GetHashCode());

            //push first state
            this.states.Push(new StateMainMenu(this.states));
        }


        private void IntGui()
        {
            this.gui = new Gui();
        }

        // Constructors and Descructors
        public Game()
        {   
            this.InitVariables();
            this.InitStates();
            this.IntGui();
        }


        public void Run()
        {
            while (this.end == false)
            {
                this.gui.render();

                Console.WriteLine("Write a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                    this.end = true;
                else
                    Console.WriteLine("You entered number: " + number); 
                
                
                

            }
            Console.WriteLine("Ending Game");
        }

    }
}
