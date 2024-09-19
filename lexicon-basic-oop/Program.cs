namespace lexicon_basic_oop;

public class Program()
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        //Person p = new Person { FirstName = "Didrik", LastName = "Molinder" };
        //p.fName = "didrik";
        //Går inte eftersom private

        try
        {
            Person newPerson = PersonHandler.CreatePerson(35, "Didrik", "Molinder", 188, 75);
            System.Console.WriteLine(newPerson.ToString());
            PersonHandler.SetAge(newPerson, 36);
            System.Console.WriteLine(newPerson.ToString());
            PersonHandler.Operate(newPerson);
            System.Console.WriteLine(newPerson.ToString());
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Exception occurred: {ex.Message}");
            Console.ForegroundColor = ConsoleColor.Green;
        }
        try
        {
            Person badPerson = PersonHandler.CreatePerson(0, "Some", "Guy", 0, 0);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Exception occurred: {ex.Message}");
            Console.ForegroundColor = ConsoleColor.Green;
        }
        try
        {
            List<UserError> userErrors = new();
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());

            foreach (var error in userErrors)
            {
                System.Console.WriteLine(error.UEMessage());
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Exception occurred: {ex.Message}");
            Console.ForegroundColor = ConsoleColor.Green;
        }
        try
        {
            Horse h = new("Dusty", 8, 400, "Palomino");
            h.DoSound();
            h.Prance();
            System.Console.WriteLine(h.ToString());
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Exception occurred: {ex.Message}");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
