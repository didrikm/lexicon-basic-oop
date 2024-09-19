namespace lexicon_basic_oop.Animals;

public class Wolf : Animal
{
    private string packStatus;

    public string PackStatus
    {
        get { return packStatus; }
        set { packStatus = value; }
    }

    public Wolf(string name, int age, double weight, string packstatus)
        : base(name, age, weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
        PackStatus = packstatus;
    }

    public override void DoSound()
    {
        System.Console.WriteLine("Awoooo!");
    }

    public override string ToString()
    {
        return $"Name: {Name}, age: {Age}, weight: {Weight}, pack status: {PackStatus}";
    }

    public void StalkPrey()
    {
        System.Console.WriteLine("*stalks prey*");
    }

    public override string Stats()
    {
        return $"Name: {Name}, Age: {Age}, weight: {Weight}, pack status: {PackStatus}";
    }
}
