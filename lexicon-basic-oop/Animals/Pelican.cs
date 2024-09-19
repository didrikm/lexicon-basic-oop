namespace lexicon_basic_oop.Animals;

public class Pelican : Bird
{
    private double beakVolume;

    public double BeakVolume
    {
        get { return beakVolume; }
        set { beakVolume = value; }
    }

    public Pelican(string name, int age, double weight, int wingspan, double beakvolume)
        : base(name, age, weight, wingspan)
    {
        Name = name;
        Age = age;
        Weight = weight;
        WingSpan = wingspan;
        BeakVolume = beakvolume;
    }
}
