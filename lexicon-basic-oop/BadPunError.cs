namespace lexicon_basic_oop;

public class BadPunError : UserError
{
    public override string UEMessage()
    {
        return "A bad pun has been detected. A reaper drone is imbound on your location.";
    }
}
