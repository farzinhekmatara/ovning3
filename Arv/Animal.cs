namespace Arv
{
    internal abstract class Animal
    {

        public int Weight { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public Animal(int age, int weight, string name)
        {
            Age = age;
            Weight = weight;
            Name = name;
        }
        public abstract string DoSound();
        public virtual string Status()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, ";
        }
    }

    class Dog : Animal
    {
        string sound = "*WoffWoff*";
        public string Color { get; set; }


        public Dog(string color, int age, int weight, string name) : base(age, weight, name)
        {
            Color = color;
        }
        public override string DoSound()
        {
            return sound;
        }


        public override string Status()
        {
            return base.Status() + $"Color: {Color}.";
        }

    }

    class Horse : Animal, IPerson
    {
        string sound = "*gnägggnägg*";

        public string Breed { get; set; }

        public Horse(int age, int weight, string name, string breed) : base(age, weight, name)
        {
            Breed = breed;
        }

        public override string DoSound()
        {
            return sound;
        }

        public override string Status()
        {
            return base.Status() + $"Breed: {Breed}.";
        }

        public string Talk()
        {
            return "Jag är en Kentaur!";
        }
    }

    //class Hedegehog : Animal
    //{
    //    String sound = "Ljud från igelkotten";
    //    string teeth;
    //    string proplist = "weight , name , age , sound , teeth";
    //    public override string DoSound()
    //    {
    //        return sound;
    //    }

    //    public override string Status()
    //    {
    //        return proplist;
    //    }
    //}

    //class Bird : Animal
    //{
    //    String sound = "Ljud från fågeln";
    //    public string eyes;
    //    string proplist = "weight , name , age , sound , eyes";
    //    public override string DoSound()
    //    {
    //        return sound;
    //    }

    //    public override string Status()
    //    {
    //        return proplist;
    //    }
    //}

    //class Pelican : Bird
    //{
    //   string sound = "Ljud från Pelikanen";
    //   public override string DoSound()
    //    {
    //        return sound;
    //    }
    //}

    //class Flamingo : Bird
    //{
    //    string color;
    //    string sound = "Ljud från Flamingon";
    //    public override string DoSound()
    //    {
    //        return sound;
    //    }
    //}


    //class Swan : Bird
    //{
    //    string sound = "Ljud från Swanen";
    //    public override string DoSound()
    //    {
    //        return sound;
    //    }
    //}


    class Wolf : Animal
    {
        string sound = "*yl!*";
        public string Country { get; set; }


        public Wolf(int age, int weight, string name, string country) : base(age, weight, name)
        {
            Country = country;
        }

        public override string DoSound()
        {
            return sound;
        }

        public override string Status()
        {
            return base.Status() + $"Country of Origin: {Country}.";
        }
    }
    public interface IPerson
    {
        public string Talk();
    }
    class Wolfman : Wolf, IPerson
    {

        public Wolfman(int age, int weight, string name, string country) : base(age, weight, name, country)
        {
        }


        public string Talk()
        {
            return "Wolfman talar";
        }
    }



    //class Worm : Animal
    //{
    //    string sound = "Ljud från masken";
    //    string ears;
    //    string proplist = "weight , name , age , sound , ears";
    //    public override string DoSound()
    //    {
    //        return sound;
    //    }

    //    public override string Status()
    //    {
    //        return proplist;
    //    }
    //}
}
