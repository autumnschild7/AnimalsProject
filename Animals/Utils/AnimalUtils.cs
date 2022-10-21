using Animals;
using System.Collections.Generic;

namespace Utils
{
    public class AnimalUtils
    {
        // make a constructor and read the list
        // make file utils and the list class variables
        FileUtils file = new FileUtils();
        List<Animal> listOfAnimals = new List<Animal>();

        public AnimalUtils()
        {
        }

        public void GetExistingAnimalList(string path)
        {
            Animal animal = new Animal();
            listOfAnimals = file.ReadFile(path);

            if (listOfAnimals == null) return;
        }

        public void AddAnimalToList(Animal newAnimal, string path)
        {
            Animal animal = new Animal
            {
                Type = newAnimal.Type,
                Name = newAnimal.Name,
                Size = newAnimal.Size,
                Noise = newAnimal.Noise,
                NumberOfFeet = newAnimal.NumberOfFeet
            };

            // Add the animal to the list
            listOfAnimals.Add(animal);

            file.WriteFile(listOfAnimals, path);
        }
    }
}
