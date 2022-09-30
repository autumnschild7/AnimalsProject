using System;
using Animals;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Utils
{
    class FileUtils
    {
        List<Animal> listOfAnimals = new List<Animal>();

        string path = Path.Combine("D:\\Kimberly\\Documents\\Goals\\AnimalsProject\\" +
            "Animals", "Animal.json");

        //Save to disk
        //handle writing to file
        public void WriteFile(Animal newAnimal)
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

            string json = JsonConvert.SerializeObject(listOfAnimals, Formatting.Indented);

            // write the list to the file.
            if (File.Exists(path))
                File.AppendAllText(path, json);
            else
                File.WriteAllText(path, json);
        }

        public void ReadFile()
        {
            Animal animal = new Animal();

            List<Animal> jsonAnimalList = JsonConvert.DeserializeObject<List<Animal>>(File.ReadAllText(path));

            foreach (var j in jsonAnimalList)
            {
                animal.Type = j.Type;
                animal.Name = j.Name;
                animal.Size = j.Size;
                animal.Noise = j.Noise;
                animal.NumberOfFeet = j.NumberOfFeet;

                listOfAnimals.Add(animal);
            }
            
            Console.WriteLine(listOfAnimals.ToString());
            Console.ReadLine();
        }
    }
}
