using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal : AnimalType
    {
        [JsonProperty("animal")]
        List<Animal> animalList { get; set; }

        public Animal() { }
    }
}
