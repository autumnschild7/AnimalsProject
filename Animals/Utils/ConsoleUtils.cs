using System;
using Animals;

namespace Utils
{
    class ConsoleUtils
    {
        //Create animal - Allow user to enter characteristics
        //type, size, name, noise, numberOfFeet
        public void EnterCharacteristics()
        {
            Animal a = new Animal();
            FileUtils file = new FileUtils();

            Console.WriteLine("Enter the type of animal. (Bird, Reptile, Mammal, etc.");
            a.Type = Console.ReadLine();
            Console.WriteLine("\r\nWhat is the name of the " + a.Type.ToLower() +
                "? \r\n(Ex: Bird names are Hummingbird, Finch, Cardinal, etc.)");
            a.Name = Console.ReadLine();
            // Check to see if the type/name combo exists - if so maybe show what we have
            Console.WriteLine("\r\nWhat size is the " + a.Name.ToLower() + "? " +
                "\r\n(Prefer Ex Small, Small, Medium, Large, Ex Large, Gigantic.)");
            a.Size = Console.ReadLine();
            Console.WriteLine("\r\nWhat noise does the " + a.Name.ToLower() + " make?");
            a.Noise = Console.ReadLine();
            Console.WriteLine("\r\nHow many feet does the " + a.Name.ToLower() + " have?");
            a.NumberOfFeet = Console.ReadLine();

            string row = a.Type + "," + a.Name + "," + a.Size + "," + a.Noise + "," + a.NumberOfFeet;

            file.WriteFile(a);
            Console.WriteLine("\r\n" + row);
            Console.Read();
        }
    }
}
