namespace lexicon_basic_oop;

public class Bird : Animal
{
    private int wingSpan;

    public int WingSpan
    {
        get { return wingSpan; }
        set { wingSpan = value; }
    }

    public Bird(string name, int age, double weight, int wingspan)
        : base(name, age, weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
        WingSpan = wingspan;
    }

    public override void DoSound()
    {
        System.Console.WriteLine("Squawk!");
    }

    public override string ToString()
    {
        return $"Name: {Name}, age: {Age}, weight: {Weight}, wing span: {WingSpan}";
    }

    public void FlapWings()
    {
        System.Console.WriteLine("*flaps wings*");
    }
}
