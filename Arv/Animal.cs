using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal abstract class Animal
    {
        public int weight;
        public string name;
        public int age;
  
        public Animal()
        {
        }      
        public abstract string DoSound();
        public abstract string Status();
    }

    class Dog : Animal
    {
        string sound = "Ljud från hunden";
        string color = "Black";
        string proplist = "weight , name , age , sound , color";
        
        public override string DoSound()
        {
            return sound;            
        }

        public int GetAge()
        {
            return age;
        }

        public override string Status() {
            return proplist;
        }

    }

    class Horse : Animal
    {
        String sound = "Ljud från hästen";
        string color="";
        string proplist = "weight , name , age , sound , color";
        public override string DoSound()
        {
            return sound;
        }

        public override string Status()
        {
            return proplist;
        }
    }

    class Hedegehog : Animal
    {
        String sound = "Ljud från igelkotten";
        string teeth;
        string proplist = "weight , name , age , sound , teeth";
        public override string DoSound()
        {
            return sound;
        }

        public override string Status()
        {
            return proplist;
        }
    }

    class Bird : Animal
    {
        String sound = "Ljud från fågeln";
        string eyes;
        string proplist = "weight , name , age , sound , eyes";
        public override string DoSound()
        {
            return sound;
        }

        public override string Status()
        {
            return proplist;
        }
    }

    class Pelican : Bird
    {
       string sound = "";
       public override string DoSound()
        {
            return sound;
        }
    }

    class Flamingo : Bird
    {
        string color;
        string sound = "";
        public override string DoSound()
        {
            return sound;
        }
    }


    class Swan : Bird
    {
        string sound = "";
        public override string DoSound()
        {
            return sound;
        }
    }


    class Wolf : Animal
    {
        string sound ;
        string country;
        string proplist = "weight , name , age , sound , country";
        public override string DoSound()
        {
            return sound;
        }

        public override string Status()
        {
            return proplist;
        }
    }

    class Wolfman : Wolf
    {
        string proplist = "weight , name , age , sound , country";
        public override string Status()
        {
            return proplist;
        }
    }

    class Worm : Animal
    {
        string sound = "";
        string ears;
        string proplist = "weight , name , age , sound , ears";
        public override string DoSound()
        {
            return sound;
        }

        public override string Status()
        {
            return proplist;
        }
    }
}
