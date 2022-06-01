using Arv;
//3.3
//Dog dog = new Dog();
//Console.WriteLine("Hunden låter som: "+dog.DoSound());

//dog.Age = 4;
//Console.WriteLine("Hunden ålder: "+dog.Age);

//3.4
List<Animal> anmimals = new List<Animal>();
anmimals.Add(new Dog("Brown", 3, 30, "Fido"));
anmimals.Add(new Horse(10, 400, "Balder", "Andalusian"));
anmimals.Add(new Wolf(3, 50, "Fenris", "Norway"));
//anmimals.Add(new Worm());
anmimals.Add(new Wolfman(40, 86, "Pelle", "Sweden"));





foreach (Animal anm in anmimals)
{

    Console.WriteLine();
    Console.WriteLine(anm.Status());
    Console.WriteLine(anm.DoSound());
    if (anm is IPerson)
    {
        IPerson person = (IPerson)anm;
        Console.WriteLine(person.Talk());
    }

    if (anm is Dog)
    {
        //gör nått
    }

    Console.WriteLine();
}


//foreach (Animal anm in anmimals)
//    if(anm is Horse)
//     Console.WriteLine( "Den här är en Häst: "+anm.Status());



//List<Dog> doglist = new List<Dog>();
//doglist.Add(new Dog());
//doglist.Add(new Dog());
//doglist.Add(new Dog());
// 10.F 11.F//doglist.Add(new Horse());// detta går inte för att Häst är inte rätt type för listan.

//Console.ReadLine(); 

//13.F: De ska läggas i fågel classen
//14.F: Detska läggas i bas klassen