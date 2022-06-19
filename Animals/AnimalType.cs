using System.Collections.Generic;

namespace Animals
{
    internal class AnimalType : IAttributes
    {
        public List<Animal> aList = new List<Animal>();
        public string Type { get; set; }


        public string Name
        {
            get; set;
        }

        public string Size
        {
            get; set;
        }

        public string Noise
        {
            get; set;
        }

        public string NumberOfFeet
        {
            get; set;
        }
    }
}
