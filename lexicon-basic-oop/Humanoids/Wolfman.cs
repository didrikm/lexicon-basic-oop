namespace lexicon_basic_oop.Humanoids;

public class WolfMan : Wolf, IPerson
{
    public WolfMan(string name, int age, double weight, string packstatus) : base(name, age, weight, packstatus)
    {
    }

    public void Talk()
    {
        System.Console.WriteLine(
            "Even a man who is pure in heart and says his prayers by night, may become a wolf when the wolfbane blooms, and the autumn moon is bright."
        );
    }
}
