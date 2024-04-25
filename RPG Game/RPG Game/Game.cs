using System;
using System.Collections;
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
        private ArrayList characterList;

        //private functians
        private void InitVariables()
        {
            this.end = false;
        }

        private void InitCharaterList()
        {
            this.characterList = new ArrayList();
        }

        private void InitStates()
        {
            this.states = new Stack<State>();

            //Console.WriteLine(this.states.GetHashCode());

            //push first state
            this.states.Push(new StateMainMenu(this.states, this.characterList));

        }


      

        // Constructors and Descructors
        public Game()
        {   
            this.InitVariables();
            this.InitCharaterList();
            this.InitStates();
 
        }


        public void Run()
        {
            while (this.states.Count > 0)
            {
              
                this.states.Peek().Update();
                   if(this.states.Peek().RequestEnd())
                        this.states.Pop();
                
                    



                
                
                

            }
            Console.WriteLine("Ending Game");
        }

    }
}
