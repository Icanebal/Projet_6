namespace Projet_6.Models.Entities
{
    public class ProductVersion
    {
        public int ProductVersionId { get; set; }
        public int ProductId { get; set; }
        public string Number { get; set; } = null!;
        public Product Product { get; set; } = null!;
        public ICollection<ProductVersionCompatibility> ProductVersionCompatibilities { get; set; } = new List<ProductVersionCompatibility>();

    }
}
