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

            file.WriteFile(a);

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
