namespace lexicon_basic_oop.UserErrors;

public class NumericInputError : UserError
{
    public override string UEMessage()
    {
        return "You tried to use a numeric input in a text only field. This fired an error!";
    }
}
