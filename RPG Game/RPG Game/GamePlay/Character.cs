using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
     class Character
    {
        //core
        private String name                 = "";
        private int level                   = 0;
        private int attrubutePoint          = 3;
        private int exp                     = 0;
        private int expMax                  = 100;


        //Attributes
        private int strength                = 1;
        private int vitality                = 1;
        private int dextarity               = 1;
        private int agility                 = 1;
        private int intelligence            = 1;


        //stats
        private int hp                      = 10;
        private int hpMax                   = 100;
        private int damage                  = 1;
        private int damageMax               = 100;
        private int accuracy                = 1;
        private int defence                 = 1;


        //general
        private int gold                    = 100;







        public String Name()
        {
            return this.name;
        }

        private void CalculateExp()
        {
            this.expMax = this.level * 100;
        }

        private void CalculateStats()
        {
            this.hp = this.vitality * 10;
            this.damageMax = this.strength * 2;
            this.damage = this.strength;
            this.accuracy = this.dextarity * 2;
            this.defence = this.agility * 2;


        }




        public Character(String name)
        {
            this.CalculateStats();
            this.name = name;
        }



        public  string ToStringBanner()
        {
            String str =
                "Active Character\n" +
                "========================================\n" +
                $"[ {this.name} | ll: {this.level} {Gui.ProgressBar(this.exp, this.expMax, 10)} ] \n " +
                "========================================\n";
            return str;
        }


        public override string ToString()
        {
            String str =
                $"Name:\t\t{this.name}\n" +
                $"Level:\t\t{this.level}\n" +
                $"Attrubute point:\t{this.attrubutePoint}\n" +
                $"Exp:\t\t{this.exp}/{this.expMax} {Gui.ProgressBar(30, 50, 10)}\n";
            return str;
        }


        public string ToStringDetailed()
        {
            String str =
                $"Name:\t\t{this.name}\n" +
                $"Level:\t\t{this.level}\n" +
                $"Attrubute point:\t{this.attrubutePoint}\n" +
                $"Exp:\t\t{this.exp}/{this.expMax}\n";
            return str;
        }

    }
}
