﻿namespace lexicon_basic_oop;

public class Program()
{
    public static void Main()
    {
        //Person p = new Person { FirstName = "Didrik", LastName = "Molinder" };
        //p.fName = "didrik";
        //Går inte eftersom private
        try
        {
            Person newPerson = PersonHandler.CreatePerson(35, "Didrik", "Molinder", 188, 75);
            System.Console.WriteLine(newPerson.ToString());
        }
        catch
        {
            System.Console.WriteLine("Exception");
        }
    }
}
