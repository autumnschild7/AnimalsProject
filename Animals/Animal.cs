

namespace Animals
{
    [System.Serializable]
    public class Animal : IAttributes
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Noise { get; set; }
        public string NumberOfFeet { get; set; }
    }
}
