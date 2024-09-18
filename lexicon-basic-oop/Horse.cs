namespace lexicon_basic_oop;

public class Horse : Animal
{
    public Horse(string name, int age, double weight)
        : base(name, age, weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public override void DoSound()
    {
        System.Console.WriteLine("Neigh!");
    }

    public void Prance()
    {
        System.Console.WriteLine("*prances*");
    }
}
