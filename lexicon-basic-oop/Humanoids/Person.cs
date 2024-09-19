namespace lexicon_basic_oop.Humanoids;

public class Person
{
    private int age;
    private string fName;
    private string lName;
    private double height;
    private double weight;
    private string healthStatus = "Undiscovered tumor";

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
            else
                throw new ArgumentException("Age must be > 0");
        }
    }

    public required string FirstName
    {
        get { return fName; }
        set
        {
            if (2 <= value.Length && value.Length <= 10)
                fName = value;
            else
                throw new ArgumentException(
                    "First name must be at least 2 characters and at most 10 characters."
                );
        }
    }

    public required string LastName
    {
        get { return lName; }
        set
        {
            if (3 <= value.Length && value.Length <= 15)
                lName = value;
            else
                throw new ArgumentException(
                    "Last name must be at least 3 characters and at most 15 characters."
                );
        }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public string HealthStatus
    {
        get { return healthStatus; }
        set { healthStatus = value; }
    }

    public override string ToString()
    {
        return $"First name: {fName}\nLast name: {lName}\nAge: {age}\nHeight: {height}\nWeight: {weight}\nHealth status: {healthStatus}";
    }

    // public Person
    // {
    //     FirstName = FName;
    //     LastName = LName;
    // }
}
