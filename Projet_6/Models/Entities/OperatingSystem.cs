namespace Projet_6.Models.Entities
{
    public class OperatingSystem
    {
        public int OperatingSystemId { get; set; }
        public string OperatingSystemName { get; set; } = null!;
        public ICollection<ProductVersionOperatingSystem> ProductVersionOperatingSystems { get; set; } = new List<ProductVersionOperatingSystem>();
    }
}