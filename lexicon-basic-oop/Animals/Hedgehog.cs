namespace lexicon_basic_oop.Animals;

public class Hedgehog : Animal
{
    private int numberOfSpines;

    public Hedgehog(string name, int age, double weight, int numberOfSpines)
        : base(name, age, weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
        NumberOfSpines = numberOfSpines;
    }

    public int NumberOfSpines
    {
        get { return numberOfSpines; }
        set { numberOfSpines = value; }
    }

    public override void DoSound()
    {
        System.Console.WriteLine("...");
    }

    public void Scurry()
    {
        System.Console.WriteLine("*scurries away*");
    }

    public override string Stats()
    {
        return $"Name: {Name}, Age: {Age}, weight: {Weight}, number of spines: {NumberOfSpines}";
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Weight: {Weight}kg, Number of Spines: {numberOfSpines}";
    }
}
