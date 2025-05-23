namespace Projet_6.Models.Entities
{
    public class ProductVersionCompatibility
    {
        public int ProductVersionCompatibilityId { get; set; }
        public int OsId { get; set; }
        public OperatingSystem OperatingSystem { get; set; } = null!;
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
