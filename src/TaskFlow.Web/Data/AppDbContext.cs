using Microsoft.EntityFrameworkCore;
using TaskFlow.Web.Domain;

namespace TaskFlow.Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Ticket> Tickets => Set<Ticket>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>(ticket =>
        {
            ticket.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            // Statut stocké en texte plutôt qu'en int : lisible directement en base
            ticket.Property(t => t.Status)
                .HasConversion<string>()
                .HasMaxLength(20);
        });
    }
}
