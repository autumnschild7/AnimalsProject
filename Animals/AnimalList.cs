using System;
using System.Collections.Generic;

namespace Animals
{
    [Serializable]
    class AnimalList
    {
        public List<Animal> animalList = new List<Animal>();

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
    }
}
