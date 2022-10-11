using Newtonsoft.Json;
using System.Collections.Generic;

namespace Animals
{
    [System.Serializable]
    public class Animal
    {
        public List<Animal> animalList = new List<Animal>();

        //[JsonProperty("one")]
        public string Type { get; set; }

        //[JsonProperty("two")]
        public string Name { get; set; }

        //[JsonProperty("three")]
        public string Size { get; set; }

        //[JsonProperty("four")]
        public string Noise { get; set; }

        //[JsonProperty("five")]
        public string NumberOfFeet { get; set; }

        public void AddAnimal(Animal newAnimal)
        {
            Animal animal = new Animal
            {
                Type = newAnimal.Type,
                Name = newAnimal.Name,
                Size = newAnimal.Size,
                Noise = newAnimal.Noise,
                NumberOfFeet = newAnimal.NumberOfFeet
            };
            animalList.Add(animal);
        }

        public void GetAnimalList(Animal theListOfAnimalsFromFile) { }
    }
}
