using Newtonsoft.Json;
using System.Collections.Generic;

namespace Animals
{
    public class Animal : IAttributes
    {
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
    }
}
