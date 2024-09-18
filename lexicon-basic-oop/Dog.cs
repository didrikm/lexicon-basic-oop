public class Dog : Animal
{
    public Dog(string name, int age, double weight)
        : base(name, age, weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public override void DoSound()
    {
        System.Console.WriteLine("Woof!");
    }

    public void Fetch()
    {
        System.Console.WriteLine("*fetches newspaper*");
    }
}
