namespace lexicon_basic_oop;

public class Hedgehog : Animal
{
    public Hedgehog(string name, int age, double weight)
        : base(name, age, weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public override void DoSound()
    {
        System.Console.WriteLine("...");
    }

    public void Scurry()
    {
        System.Console.WriteLine("*scurries away*");
    }
}
