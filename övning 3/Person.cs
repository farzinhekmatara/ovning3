using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Person
{
    private string fName;
    private string lName;
    private double height;
    private double weight;
    private int age;
  

    public Person(int age , string fName , string lname , double height, double weight)
    {
        this.age = age;
        this.fName = fName;
        this.lName = lname;
        this.height = height;
        this.weight = weight;
    }

    public void SetfName(string fname)
    {
        this.fName = fname;
    }

    public string GetfName()
    {
        return this.fName;
    }

    public void setlName(string lName)
    {
        this.lName = lName;
    }

    public string GetLname()
    {
        return lName;
    }

    public void SetHeight(int height)
    {
        this.height = height;
    }

    public double GetHeight()
    {
        return this.height;
    }

    public void SetWeight(double weight)
    {
        this.weight = weight;
    }

    public double GetWeight()
    {
        return weight;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetAge()
    {
        return this.age;
    }
}