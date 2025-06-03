namespace Projet_6.Models.Dtos
{
    public class TicketDto
    {
        public int TicketId { get; set; }
        public string? Produit { get; set; }
        public string? Version { get; set; }
        public string OS { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? Issue { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public string? Resolution { get; set; }
        public string Statut { get; set; }
    }

}
