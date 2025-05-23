namespace Projet_6.Models.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int ProductVersionCompatibilityId { get; set; }
        public int TicketStatusId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public string Issue { get; set; } = null!;
        public string? Resolution { get; set; }
        public ProductVersionCompatibility ProductVersionCompatibility { get; set; } = null!;
        public TicketStatus TicketStatus { get; set; } = null!;
    }
}
