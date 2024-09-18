public class Wolf : Animal
{
    public Wolf(string name, int age, double weight)
        : base(name, age, weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public override void DoSound()
    {
        System.Console.WriteLine("Awoooo!");
    }

    public void StalkPrey()
    {
        System.Console.WriteLine("*stalks prey*");
    }
}
