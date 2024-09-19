namespace lexicon_basic_oop;

public class Bird : Animal
{
    public Bird(string name, int age, double weight)
        : base(name, age, weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public override void DoSound()
    {
        System.Console.WriteLine("Squawk!");
    }

    public void FlapWings()
    {
        System.Console.WriteLine("*flaps wings*");
    }
}
