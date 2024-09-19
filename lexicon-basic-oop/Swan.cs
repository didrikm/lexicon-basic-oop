namespace lexicon_basic_oop;

public class Swan : Bird
{
    private double neckLength;

    public double NeckLength
    {
        get { return neckLength; }
        set { neckLength = value; }
    }

    public Swan(string name, int age, double weight, int wingspan, double necklength)
        : base(name, age, weight, wingspan)
    {
        Name = name;
        Age = age;
        Weight = weight;
        WingSpan = wingspan;
        NeckLength = necklength;
    }
}
