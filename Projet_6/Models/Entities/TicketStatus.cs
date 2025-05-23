namespace Projet_6.Models.Entities
{
    public class TicketStatus
    {
        public int TicketStatusId { get; set; }
        public string Label { get; set; } = null!;

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
