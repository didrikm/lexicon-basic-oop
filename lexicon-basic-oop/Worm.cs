namespace lexicon_basic_oop;

public class Worm : Animal
{
    private double length;

    public Worm(string name, int age, double weight, double length)
        : base(name, age, weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
        Length = length;
    }

    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public override void DoSound()
    {
        System.Console.WriteLine("...");
    }

    public void Wriggle()
    {
        System.Console.WriteLine("*wriggles*");
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Length: {Length}";
    }
}
