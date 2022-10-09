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

        AnimalList aList = new AnimalList();

        //Save to disk
        //handle writing to file
        public void WriteFile(Animal animal)
        {
            if (animal == null)
                return;

            // Add the animal to the list
            aList.AddAnimal(animal);

            string json = JsonConvert.SerializeObject(aList.animalList, Formatting.Indented);

            //write the list to the file.
            if (File.Exists(path))
                File.AppendAllText(path, json);
            else
                File.WriteAllText(path, json);
        }

        public void ReadFile()
        {
            Animal animal = new Animal();

            List<Animal> jsonAnimalList = JsonConvert.DeserializeObject<List<Animal>>(File.ReadAllText(path));
            var animalsFromFile = new List<Animal>();

            foreach (var j in jsonAnimalList)
            {
                animal.Type = j.Type;
                animal.Name = j.Name;
                animal.Size = j.Size;
                animal.Noise = j.Noise;
                animal.NumberOfFeet = j.NumberOfFeet;

                animalsFromFile.Add(animal);
            }
            
            aList.animalList = animalsFromFile;

            Console.WriteLine(aList.animalList.ToString());
            //Console.ReadLine();
        }
    }
}
