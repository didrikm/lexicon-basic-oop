using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace lexicon_basic_oop;

public class Program()
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        //F 1: Man kommer åt props i och med get, men inte de privata fälten direkt


        Person newPerson = PersonHandler.CreatePerson(35, "Didrik", "Molinder", 188, 75);
        System.Console.WriteLine(newPerson.ToString());
        PersonHandler.SetAge(newPerson, 36);
        System.Console.WriteLine(newPerson.ToString());
        PersonHandler.Operate(newPerson);
        System.Console.WriteLine(newPerson.ToString());

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

        System.Console.WriteLine();

        Horse h = new("Dusty", 8, 400, "Palomino");
        h.DoSound();
        h.Prance();
        System.Console.WriteLine(h.ToString());

        System.Console.WriteLine();

        Pelican pelican = new("Pelle", 2, 15, 192, 13.2);
        System.Console.WriteLine(pelican.BeakVolume);

        System.Console.WriteLine();

        WolfMan wolfman = new WolfMan("John Talbot", 55, 70, "Alpha");
        wolfman.Talk();
        System.Console.WriteLine(wolfman.ToString());
        //F 13: i Bird.cs
        //F 14: i Animal.cs


        System.Console.WriteLine();

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

        System.Console.WriteLine();

        List<Dog> dogs = new();
        dogs.Add(new Dog("Tramp", 5, 25, "Mixed"));
        dogs.Add(new Dog("Lady", 3, 18, "Cocker Spaniel"));
        dogs.Add(new Dog("Fido", 10, 35, "Mixed"));
        //dogs.Add(new Horse("Misty", 5, 380, "Grey"));
        //F 3.4.9: För det är en instans av Horse och listan accepterar bara instanser av Dog
        //F 3.4.10: Animal


        System.Console.WriteLine();

        foreach (var animal in animals)
        {
            System.Console.WriteLine(animal.Stats());
            //F 3.4.13: den loopar igenom och anropar metoden Stats på varje instans i animals
        }

        System.Console.WriteLine();

        foreach (var animal in animals)
        {
            if (animal is Dog dog)
                System.Console.WriteLine(animal.Stats());
        }

        System.Console.WriteLine();
    }
}
