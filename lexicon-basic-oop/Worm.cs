namespace lexicon_basic_oop;

public class Worm : Animal
{
    public Worm(string name, int age, double weight)
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

    public void Wriggle()
    {
        System.Console.WriteLine("*wriggles*");
    }
}
