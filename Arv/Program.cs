using Arv;
//3.3
Dog dog = new Dog();
Console.WriteLine("Hunden låter som: "+dog.DoSound());

dog.age = 4;
Console.WriteLine("Hunden ålder: "+dog.GetAge());

//3.4
List <Animal> anmimals= new List<Animal>();
anmimals.Add(new Dog());
anmimals.Add(new Horse());
anmimals.Add(new Wolf());
anmimals.Add(new Worm());
anmimals.Add(new Wolfman());





foreach (Animal anm in anmimals) { 
    Console.WriteLine(anm.Status());
    if( anm is Wolfman)
    {
        try
        {
            //IPerson person = new Wolfman();            
            IPerson person = (IPerson)anm;
            Console.WriteLine(person.Talk());
        }
        catch (Exception e)
        {
            string? stackTrace = e.StackTrace;
            if (stackTrace != null)
                Console.WriteLine(stackTrace);
        }
    }
}


foreach (Animal anm in anmimals)
    if(anm is Horse)
     Console.WriteLine( "Den här är en Häst: "+anm.Status());



List<Dog> doglist = new List<Dog>();
doglist.Add(new Dog());
doglist.Add(new Dog());
doglist.Add(new Dog());
// 10.F 11.F//doglist.Add(new Horse());// detta går inte för att Häst är inte rätt type för listan.

Console.ReadLine(); 

//13.F: De ska läggas i fågel classen
//14.F: Detska läggas i bas klassen