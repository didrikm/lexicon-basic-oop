namespace lexicon_basic_oop.Animals;

public class Flamingo : Bird
{
    private string hexColorPink;

    public string HexColorPink
    {
        get { return hexColorPink; }
        set { hexColorPink = value; }
    }

    public Flamingo(string name, int age, double weight, int wingspan, string hexcolorpink)
        : base(name, age, weight, wingspan)
    {
        Name = name;
        Age = age;
        Weight = weight;
        WingSpan = wingspan;
        HexColorPink = hexcolorpink;
    }
}
