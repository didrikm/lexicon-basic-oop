namespace lexicon_basic_oop;

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
        Person p = new Person { FirstName = fname, LastName = lname };
        p.Age = age;
        p.Height = height;
        p.Weight = weight;
        return p;
    }
}
