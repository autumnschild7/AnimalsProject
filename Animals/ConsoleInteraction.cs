using Utils;
using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Animals
{
    class ConsoleInteraction
    {
        //string projectPath = Path.Combine("D:\\Kimberly\\Documents\\Goals\\AnimalsProject\\" +
        //    "Animals", "Animal.json");

        string downloadsPath = Path.Combine(KnownFolders.GetPath(KnownFolders.Downloads), "Animal.json");

        AnimalUtils au = new AnimalUtils();
        StringUtils su = new StringUtils();

        public void GetAnimalList()
        {
            au.GetExistingAnimalList(downloadsPath);
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
            string uppercaseAnswer;

            Console.WriteLine("Enter the type of animal. (Bird, Reptile, Mammal, etc.");
            a.Type = Console.ReadLine();
            txtValidation = su.ValidateText(a.Type);
            while (txtValidation == false)
            {
                Console.WriteLine("Enter the type of animal. (Bird, Reptile, Mammal, etc.");
                a.Type = Console.ReadLine();
                txtValidation = su.ValidateText(a.Type);
            }
            uppercaseAnswer = su.UppercaseFirst(a.Type);
            a.Type = uppercaseAnswer;

            Console.WriteLine("\r\nWhat is the name of the " + a.Type.ToLower() +
                "? \r\n(Ex: Bird names are Hummingbird, Finch, Cardinal, etc.)");
            a.Name = Console.ReadLine();
            txtValidation = su.ValidateText(a.Name);
            while (txtValidation == false)
            {
                Console.WriteLine("\r\nWhat is the name of the " + a.Type.ToLower() +
                    "? \r\n(Ex: Bird names are Hummingbird, Finch, Cardinal, etc.)");
                a.Name = Console.ReadLine();
                txtValidation = su.ValidateText(a.Name);
            }
            uppercaseAnswer = su.UppercaseFirst(a.Name); 
            a.Name = uppercaseAnswer;

            // Check to see if the type/name combo exists - if so maybe show what we have

            Console.WriteLine("\r\nWhat size is the " + a.Name.ToLower() + "? " +
                "\r\n(Prefer Ex Small, Small, Medium, Large, Ex Large, Gigantic.)");
            a.Size = Console.ReadLine();
            txtValidation = su.ValidateText(a.Size);
            while (txtValidation == false)
            {
                Console.WriteLine("\r\nWhat size is the " + a.Name.ToLower() + "? " +
                    "\r\n(Prefer Ex Small, Small, Medium, Large, Ex Large, Gigantic.)");
                a.Size = Console.ReadLine();
                txtValidation = su.ValidateText(a.Size);
            }
            uppercaseAnswer = su.UppercaseFirst(a.Size); 
            a.Size = uppercaseAnswer;

            Console.WriteLine("\r\nWhat noise does the " + a.Name.ToLower() + " make?");
            a.Noise = Console.ReadLine();
            txtValidation = su.ValidateText(a.Noise);
            while (txtValidation == false)
            {
                Console.WriteLine("\r\nWhat noise does the " + a.Name.ToLower() + " make?");
                a.Noise = Console.ReadLine();
                txtValidation = su.ValidateText(a.Noise);
            }
            uppercaseAnswer = su.UppercaseFirst(a.Noise);
            a.Noise = uppercaseAnswer;

            Console.WriteLine("\r\nHow many feet does the " + a.Name.ToLower() + " have?");
            a.NumberOfFeet = Console.ReadLine();
            while (txtValidation == false)
            {
                Console.WriteLine("\r\nHow many feet does the " + a.Name.ToLower() + " have?");
                a.Noise = Console.ReadLine();
                txtValidation = su.ValidateText(a.NumberOfFeet);
            }
            uppercaseAnswer = su.UppercaseFirst(a.NumberOfFeet); 
            a.NumberOfFeet = uppercaseAnswer;

            //call add to list then call write file from that
            au.AddAnimalToList(a, downloadsPath);

            string row = a.Type + "," + a.Name + "," + a.Size + "," + a.Noise + "," + a.NumberOfFeet;

            Console.WriteLine("\r\n" + row);
            Console.Read();
        }
    }
    public static class KnownFolders
    {
        public static Guid Contacts = new Guid("{56784854-C6CB-462B-8169-88E350ACB882}");
        public static Guid Desktop = new Guid("{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}");
        public static Guid Documents = new Guid("{FDD39AD0-238F-46AF-ADB4-6C85480369C7}");
        public static Guid Downloads = new Guid("{374DE290-123F-4565-9164-39C4925E467B}");
        public static Guid Favorites = new Guid("{1777F761-68AD-4D8A-87BD-30B759FA33DD}");
        public static Guid Links = new Guid("{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}");
        public static Guid Music = new Guid("{4BD8D571-6D19-48D3-BE97-422220080E43}");
        public static Guid Pictures = new Guid("{33E28130-4E1E-4676-835A-98395C3BC3BB}");
        public static Guid SavedGames = new Guid("{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}");
        public static Guid SavedSearches = new Guid("{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}");
        public static Guid Videos = new Guid("{18989B1D-99B5-455B-841C-AB7C74E4DDFC}");

        static Dictionary<string, Guid> Map { get; } = new Dictionary<string, Guid> {
        { nameof(Contacts), Contacts },
        { nameof(Desktop), Desktop },
        { nameof(Documents), Documents },
        { nameof(Downloads), Downloads },
        { nameof(Favorites), Favorites },
        { nameof(Links), Links },
        { nameof(Music), Music },
        { nameof(Pictures), Pictures },
        { nameof(SavedGames), SavedGames },
        { nameof(SavedSearches), SavedSearches },
        { nameof(Videos), Videos },
    };
        [Flags]
        public enum KnownFolderFlags : uint
        {
            SimpleIDList = 0x00000100
        , NotParentRelative = 0x00000200, DefaultPath = 0x00000400, Init = 0x00000800
        , NoAlias = 0x00001000, DontUnexpand = 0x00002000, DontVerify = 0x00004000
        , Create = 0x00008000, NoAppcontainerRedirection = 0x00010000, AliasOnly = 0x80000000
        }

        public static string GetPath(string knownFolder,
            KnownFolderFlags flags = KnownFolderFlags.DontVerify, bool defaultUser = false) =>
            Map.TryGetValue(knownFolder, out var knownFolderId)
                ? GetPath(knownFolderId, flags, defaultUser)
                : ThrowUnknownFolder();

        public static string GetPath(Guid knownFolderId,
            KnownFolderFlags flags = KnownFolderFlags.DontVerify, bool defaultUser = false)
        {
            if (SHGetKnownFolderPath(knownFolderId, (uint)flags, new IntPtr(defaultUser ? -1 : 0), out var outPath) >= 0)
            {
                string path = Marshal.PtrToStringUni(outPath);
                Marshal.FreeCoTaskMem(outPath);
                return path;
            }
            return ThrowUnknownFolder();
        }

        //[DoesNotReturn]
        static string ThrowUnknownFolder() =>
            throw new NotSupportedException("Unable to retrieve the path for known folder. It may not be available on this system.");

        [DllImport("Shell32.dll")]
        private static extern int SHGetKnownFolderPath(
            [MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr ppszPath);
    }
}
