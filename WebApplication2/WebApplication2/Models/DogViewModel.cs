namespace WebApplication2.Models
{
    public class DogViewModel
    {
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public void Deconstruct(out string Name, out int Age, out string OwnerName, out float Weight)
        {   // деструктуризация
            Name = this.Name;
            Age = this.Age;
            OwnerName = this.OwnerName;
            Weight = this.Weight;
        }
    }
}
