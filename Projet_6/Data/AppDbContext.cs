namespace Projet_6.Data
{
    using Microsoft.EntityFrameworkCore;
    using Projet_6.Models.Entities;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<OperatingSystem> OperatingSystems { get; set; }
        public DbSet<ProductVersion> ProductVersions { get; set; }
        public DbSet<ProductVersionOperatingSystem> ProductVersionOperatingSystems { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }
    }

}
