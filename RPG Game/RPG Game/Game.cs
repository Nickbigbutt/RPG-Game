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
            this.states.Push(new State(this.states));
        }


        // Constructors and Descructors
        public Game()
        {
            this.InitVariables();
            this.InitStates();

            Console.WriteLine("Hello from the game Class"); 
        }


        public void Run()
        {
            while (this.end == false)
            {
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
