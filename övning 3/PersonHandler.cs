using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class PersonHandler
{
    private List<Person> personList;
    public PersonHandler()
    {
        personList = new List<Person>();
    }

    public void CreatePerson(int age, string fname , string lname , double height , double weight)
    {
        CheckTheParameter(age, fname, lname, height, weight);     
    }    

    private void CheckTheParameter(int age, string fname, string lname, double height, double weight)
    {         
        if (CheckAge(age) && CheckfName(fname) && 
            CheckLname(lname) && CheckHeight(height)
            && CheckHeight(height))
            AddToList(new Person(age, fname, lname, height, weight));
    }   

    private bool CheckAge(int age)
    {
        try
        {
            if(age < 0)
                throw new ArgumentException();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Fel ålder(ålder < 0) :{e.Message.ToString()}");
        }       
        return true;
    }

    private bool CheckfName(string fname)
    {
        try
        {
            if (fname.Length > 10 || fname.Length < 2)               
                throw new ArgumentException();
        }
        catch (ArgumentException e)
        {            
            Console.WriteLine($"Fel förnamn(antal tecken) :{e.Message.ToString()}");
        }
        return true;
    }

    private bool CheckLname(string lname)
    {       
        try
        {
            if (lname.Length > 15 || lname.Length < 3)
                throw new ArgumentException();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Fel efterförnamn(antal tecken) :{e.Message.ToString()}");          
        }       
        return true;
    }


    private bool CheckHeight(double height)
    {
        try
        {
            if(height < 0)
            throw new ArgumentException();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Fel längd(negativ tal) :{e.Message.ToString()}");            
        }
       
        return true;
    }

    private bool CheckWeight(double weight)
    {
        try
        {
            if(weight < 0)
                throw new ArgumentException();
        }
        catch (ArgumentException e)
        {        
            Console.WriteLine($"Vikt är oglitig(negativ tal): {e.Message.ToString()}");
        }        
        return true;
    }

    private void AddToList(Person person)
    {
       personList.Add(person);
    }

    public void SetAge(Person person , int age)
    {

        try
        {
            if (age < 0)
                throw new ArgumentException();
            else
                person.SetAge(age);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("*******************");
            Console.WriteLine($"Fel ålder genererad i SetAge() metoden(negativ tal) :{e.Message.ToString()}");
            Console.WriteLine("*******************");
        }      
    }

    public List<Person> GetPersonList()
    {
        return personList.ToList();
    }
}

