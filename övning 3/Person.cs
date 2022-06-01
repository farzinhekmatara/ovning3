internal class Person
{
    private string fName;
    private string lName;
    private double height;
    private double weight;
    private int age;


    public Person(int age, string fName, string lname, double height, double weight)
    {
        this.age = age;
        FirstName = fName;
        this.lName = lname;
        this.height = height;
        this.weight = weight;
    }

    // var person = new Person(12, "David" ,..."")


    public string FirstName
    {
        get => fName;
        set
        {
            if (value.Length > 2 && value.Length < 10)
            {
                fName = value;
            }
            else
            {
                throw new ArgumentException("First name must be between 2 and 10 characters.");
            }
        }

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