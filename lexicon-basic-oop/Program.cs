using System.Runtime.InteropServices;

namespace lexicon_basic_oop;

public class Program()
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        //F 1: Man kommer åt props i och med get, men inte de privata fälten direkt

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

        System.Console.WriteLine();

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

        System.Console.WriteLine();

        try
        {
            List<UserError> userErrors = new();
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new WetSocksError());
            userErrors.Add(new BadPunError());
            userErrors.Add(new SegFaultError());

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

        System.Console.WriteLine();

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

        System.Console.WriteLine();

        try
        {
            Pelican pelican = new("Pelle", 2, 15, 192, 13.2);
            System.Console.WriteLine(pelican.BeakVolume);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Exception occurred: {ex.Message}");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        System.Console.WriteLine();

        try
        {
            WolfMan wolfman = new WolfMan("John Talbot", 55, 70, "Alpha");
            wolfman.Talk();
            System.Console.WriteLine(wolfman.ToString());
            //F 13: i Bird.cs
            //F 14: i Animal.cs
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Exception occurred: {ex.Message}");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        System.Console.WriteLine();

        try
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Worm("Marre", 1, 0.05, 8.2));
            animals.Add(new Dog("Fifi", 2, 8, "Dachshund"));
            animals.Add(new Hedgehog("Frank", 3, 2.5, 500));
            animals.Add(new WolfMan("Cooper", 27, 83, "Omega"));

            foreach (var animal in animals)
            {
                System.Console.WriteLine(animal.GetType());
                animal.DoSound();
                if (animal is IPerson iperson)
                    iperson.Talk();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Exception occurred: {ex.Message}");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        System.Console.WriteLine();
    }
}
