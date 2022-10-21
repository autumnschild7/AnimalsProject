using Utils;
using System;
using System.IO;

namespace Animals
{
    class ConsoleInteraction
    {
        string path = Path.Combine("D:\\Kimberly\\Documents\\Goals\\AnimalsProject\\" +
            "Animals", "Animal.json");
        //string path = Path.Combine("D:\\Goals\\AnimalsProject\\Animals", "Animal.json");

        AnimalUtils au = new AnimalUtils();

        public void GetAnimalList()
        {
            au.GetExistingAnimalList(path);
            PromptUser();
        }

        //Console app -prompt for View animals, Display animals
        public void PromptUser()
        {
            int choice;

            //Console app -prompt for View animals
            //prompt to add new animal
            Console.WriteLine("Enter 1 to view animals. \r\nEnter 2 to create a new animal.");

            //Display animals
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                //handle reading from file
                //App should load animals file - “animals.json”
                // call function to read a file and display animals
                Console.WriteLine("Coming soon. Press any key to close.");
                Console.ReadLine();
            }

            //prompt to add new animal
            if (choice == 2)
            {
                this.EnterCharacteristics();
            }
        }
        //Create animal - Allow user to enter characteristics
        //type, size, name, noise, numberOfFeet
        public void EnterCharacteristics()
        {
            Animal a = new Animal();
            bool txtValidation;

            Console.WriteLine("Enter the type of animal. (Bird, Reptile, Mammal, etc.");
            a.Type = Console.ReadLine();
            txtValidation = ValidateText(a.Type);
            while (txtValidation == false)
            {
                Console.WriteLine("Enter the type of animal. (Bird, Reptile, Mammal, etc.");
                a.Type = Console.ReadLine();
                txtValidation = ValidateText(a.Type);
            }

            Console.WriteLine("\r\nWhat is the name of the " + a.Type.ToLower() +
                "? \r\n(Ex: Bird names are Hummingbird, Finch, Cardinal, etc.)");
            a.Name = Console.ReadLine();
            txtValidation = ValidateText(a.Name);
            while (txtValidation == false)
            {
                Console.WriteLine("\r\nWhat is the name of the " + a.Type.ToLower() +
                    "? \r\n(Ex: Bird names are Hummingbird, Finch, Cardinal, etc.)");
                a.Name = Console.ReadLine();
                txtValidation = ValidateText(a.Name);
            }

            // Check to see if the type/name combo exists - if so maybe show what we have

            Console.WriteLine("\r\nWhat size is the " + a.Name.ToLower() + "? " +
                "\r\n(Prefer Ex Small, Small, Medium, Large, Ex Large, Gigantic.)");
            a.Size = Console.ReadLine();
            txtValidation = ValidateText(a.Size);
            while (txtValidation == false)
            {
                Console.WriteLine("\r\nWhat size is the " + a.Name.ToLower() + "? " +
                    "\r\n(Prefer Ex Small, Small, Medium, Large, Ex Large, Gigantic.)");
                a.Size = Console.ReadLine();
                txtValidation = ValidateText(a.Size);
            }

            Console.WriteLine("\r\nWhat noise does the " + a.Name.ToLower() + " make?");
            a.Noise = Console.ReadLine();
            txtValidation = ValidateText(a.Noise);
            while (txtValidation == false)
            {
                Console.WriteLine("\r\nWhat noise does the " + a.Name.ToLower() + " make?");
                a.Noise = Console.ReadLine();
                txtValidation = ValidateText(a.Noise);
            }

            Console.WriteLine("\r\nHow many feet does the " + a.Name.ToLower() + " have?");
            a.NumberOfFeet = Console.ReadLine();
            //ValidateText(a.NumberOfFeet);

            //call add to list then call write file from that
            au.AddAnimalToList(a, path);

            string row = a.Type + "," + a.Name + "," + a.Size + "," + a.Noise + "," + a.NumberOfFeet;

            Console.WriteLine("\r\n" + row);
            Console.Read();
        }

        bool ValidateText(string incomingTxt)
        {
            int checkForInt;

            if (int.TryParse(incomingTxt, out checkForInt))
            {
                Console.WriteLine("Input cannot be a number. Try again.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(incomingTxt))
            {
                Console.WriteLine("Something went wrong. Please try again.");
                return false;
            }
            else
                return true;
        }
    }
}
