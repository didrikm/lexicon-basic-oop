namespace lexicon_basic_oop.Animals;

public abstract class Animal
{
    private string name;
    private int age;
    private double weight;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public abstract void DoSound();

    public Animal(string name, int age, double weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }
}
