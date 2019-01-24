using POCO.Enums;

namespace POCO
{
    public class Pet
    {
        public string name { get; set; }
        public int age { get; set; }
        public Animal type { get; set; }
        public Gender gender { get; set; }
    }
}