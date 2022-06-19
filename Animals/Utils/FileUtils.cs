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
        string path = Path.Combine("D:\\Kimberly\\Documents\\Goals\\Animals", "Animal.json");

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

            string json = JsonConvert.SerializeObject(animal, Formatting.Indented);

            // write the list to the file.
            File.WriteAllText(path, json);
        }

        public List<string> ReadFile()
        {
            Animal animal = new Animal();
            List<string> aList = new List<string>();

            Animal json = JsonConvert.DeserializeObject<Animal>(File.ReadAllText(path));

            Console.WriteLine(json.Type);

            return aList;            
        }
    }
}
