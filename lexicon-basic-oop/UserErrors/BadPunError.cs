namespace lexicon_basic_oop.UserErrors;

public class BadPunError : UserError
{
    public override string UEMessage()
    {
        return "A bad pun has been detected. A reaper drone is inbound to your location.";
    }
}
