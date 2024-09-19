namespace lexicon_basic_oop.Animals;

public class Horse : Animal
{
    private string _color;

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public Horse(string name, int age, double weight, string color)
        : base(name, age, weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
        Color = color;
    }

    public override void DoSound()
    {
        System.Console.WriteLine("Neigh!");
    }

    public override string ToString()
    {
        return $"This horse is called {Name}, it is {Age} years old, weighs {Weight} kilos and has a {Color} coloring.";
    }

    public void Prance()
    {
        System.Console.WriteLine("*prances*");
    }
}
