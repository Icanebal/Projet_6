namespace Projet_6.Models.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public ICollection<ProductVersion> Versions { get; set; } = new List<ProductVersion>();
    }
}
