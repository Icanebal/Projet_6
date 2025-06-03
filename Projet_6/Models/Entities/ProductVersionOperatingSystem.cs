namespace Projet_6.Models.Entities
{
    public class ProductVersionOperatingSystem
    {
        public int ProductVersionOperatingSystemId { get; set; }
        public int ProductVersionId { get; set; }
        public ProductVersion ProductVersion { get; set; } = null!;
        public int OperatingSystemId { get; set; }
        public OperatingSystem OperatingSystem { get; set; } = null!;
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
