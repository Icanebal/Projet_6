namespace Projet_6.Models.Entities
{
    public class OperatingSystem
    {
        public int OsId { get; set; }
        public string OsName { get; set; } = null!;
        public ICollection<ProductVersionCompatibility> ProductVersionCompatibilities { get; set; } = new List<ProductVersionCompatibility>();
    }
}