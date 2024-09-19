namespace lexicon_basic_oop.Animals;

public class Dog : Animal
{
    private string breed;

    public Dog(string name, int age, double weight, string breed)
        : base(name, age, weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
        Breed = breed;
    }

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    public override void DoSound()
    {
        System.Console.WriteLine("Woof!");
    }

    public void Fetch()
    {
        System.Console.WriteLine("*fetches newspaper*");
    }

    public override string Stats()
    {
        return $"Name: {Name}, Age: {Age}, weight: {Weight}, breed: {Breed}";
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Breed: {Breed}";
    }
}
