namespace lexicon_basic_oop.Humanoids;

public class PersonHandler
{
    public static Person CreatePerson(
        int age,
        string fname,
        string lname,
        double height,
        double weight
    )
    {
        Person p = new Person
        {
            FirstName = fname,
            LastName = lname,
            Age = age,
            Height = height,
            Weight = weight,
        };
        return p;
    }

    public static void SetAge(Person pers, int age)
    {
        pers.Age = age;
    }

    public static void Operate(Person pers)
    {
        pers.HealthStatus = "Recovering from surgery";
    }
}
