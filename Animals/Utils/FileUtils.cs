using System;
using Animals;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Utils
{
    public class FileUtils
    {
        //Save to disk
        //handle writing to file
        public void WriteFile(List<Animal> animalList, string path)
        {
            if (animalList == null)
                return;

            string json = JsonConvert.SerializeObject(animalList, Formatting.Indented);

            //write the list to the file.
            File.WriteAllText(path, json);
        }

        public List<Animal> ReadFile(string path)
        {
            if (File.Exists(path) == false) return null;

            return JsonConvert.DeserializeObject<List<Animal>>(File.ReadAllText(path));
        }
    }
}
