namespace lexicon_basic_oop;

public class WetSocksError : UserError
{
    public override string UEMessage()
    {
        return "Oh no your socks are wet. Go change.";
    }
}
