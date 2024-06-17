using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   

    internal class Character
    {
        public string name;
        public int pv;
        public int att;
        public int def;


        public Character(string name, int pdv, int attaque, int defense)
        {
            this.name = name;
            this.pv = pdv;
            this.att = attaque;
            this.def = defense; 
        }

        public void Attack(Character attaque)
        {
            attaque.pv -= (this.att - attaque.def);
            
        }

        public bool IsAlive()
        {
            if (this.pv <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }


    
}
