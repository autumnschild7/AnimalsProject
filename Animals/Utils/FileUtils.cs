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
        //string path = Path.Combine("D:\\Kimberly\\Documents\\Goals\\AnimalsProject\\" +
        //    "Animals", "Animal.json");
        string path = Path.Combine("D:\\Goals\\AnimalsProject\\Animals", "Animal.json");

        Animal animal = new Animal();

        //Save to disk
        //handle writing to file
        public void WriteFile(Animal newAnimal)
        {
            if (newAnimal == null)
                return;

            // Add the animal to the list
            animal.AddAnimal(newAnimal);

            string animalData = JsonConvert.SerializeObject(animal.animalList, Formatting.Indented);

            //write the list to the file.
            if (File.Exists(path))
                File.AppendAllText(path, animalData);
            else
                File.WriteAllText(path, animalData);
        }

        public string ReadFile()
        {
            if (File.Exists(path) == false) return "Incorrect file path.";

            Animal animal = new Animal();

            String contents = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<string>(contents);
        }
    }
}
