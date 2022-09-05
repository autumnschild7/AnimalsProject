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
        string path = Path.Combine("D:\\Kimberly\\Documents\\Goals\\AnimalsProject\\" +
            "Animals", "Animal.json");

        //Save to disk
        //handle writing to file
        public void WriteFile(Animal newAnimal)
        {
            List<Animal> animalList = new List<Animal>();

            Animal animal = new Animal
            {
                Type = newAnimal.Type,
                Name = newAnimal.Name,
                Size = newAnimal.Size,
                Noise = newAnimal.Noise,
                NumberOfFeet = newAnimal.NumberOfFeet
            };

            // Add the animal to the list
            animalList.Add(animal);

            string json = JsonConvert.SerializeObject(animalList, Formatting.Indented);

            // write the list to the file.
            if (File.Exists(path))
                File.AppendAllText(path, json);
            else
                File.WriteAllText(path, json);
        }

        public void ReadFile()
        {
            Animal animal = new Animal();
            List<Animal> aList = new List<Animal>();

            List<Animal> jsonAnimalList = JsonConvert.DeserializeObject<List<Animal>>(File.ReadAllText(path));

            foreach (var j in jsonAnimalList)
            {
                animal.Type = j.Type;
                animal.Name = j.Name;
                animal.Size = j.Size;
                animal.Noise = j.Noise;
                animal.NumberOfFeet = j.NumberOfFeet;

                aList.Add(animal);
            }
            
            Console.WriteLine(aList.ToString());
            Console.ReadLine();
        }
    }
}
