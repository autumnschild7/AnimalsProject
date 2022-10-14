using System;
using Animals;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class AnimalUtils
    {
        // make a constructor and read the list
        // make file utils and the list class variables
        FileUtils file = new FileUtils();
        List<Animal> listOfAnimals = new List<Animal>();
        Animal animal = new Animal();

        public AnimalUtils()
        {
        }

        public void GetExistingAnimalList(string path)
        {
            listOfAnimals = file.ReadFile(path);

            foreach (var a in listOfAnimals.ToList())
            {
                animal.Type = a.Type;
                animal.Name = a.Name;
                animal.Size = a.Size;
                animal.Noise = a.Noise;
                animal.NumberOfFeet = a.NumberOfFeet;

                listOfAnimals.Add(animal);
            }
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
