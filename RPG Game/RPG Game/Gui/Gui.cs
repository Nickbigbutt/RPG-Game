using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
     class Gui
    {

        private string header;
        public string Header
        {
            get { return this.header; }
            set { this.header = value; }
        }

        public Gui()
        {
            this.header =
            "Welcome to my game"
            + "\n"
            + "==========================" 
            + "\n"; 

        }

        public void render()
        {
            Console.WriteLine(this.header);
        }

    }
}
