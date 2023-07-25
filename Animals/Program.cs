

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            PromptUser();

            //Console app -prompt for View animals, Display animals
            void PromptUser()
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
                    //Console.WriteLine("Nothing here yet - anything will get you out of here.");
                    FileUtils f = new FileUtils();
                    f.ReadFile();
                }

                //prompt to add new animal
                if (choice == 2)
                {
                    ConsoleUtils c = new ConsoleUtils();
                    c.EnterCharacteristics();
                }
            }
        }
    }
}
