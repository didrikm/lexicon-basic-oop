namespace lexicon_basic_oop.UserErrors;

public class SegFaultError : UserError
{
    public override string UEMessage()
    {
        return "A SegFault has occurred. ETimedOut is written in blood on the wall.";
    }
}
