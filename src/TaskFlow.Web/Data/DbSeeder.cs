using TaskFlow.Web.Domain;

namespace TaskFlow.Web.Data;

public static class DbSeeder
{
    public static void Seed(AppDbContext db)
    {
        if (db.Tickets.Any())
        {
            return;
        }

        db.Tickets.AddRange(
            new Ticket { Title = "Mettre en place le squelette du projet", Status = TicketStatus.Done },
            new Ticket { Title = "Construire le board Kanban (KnockoutJS)", Status = TicketStatus.InProgress },
            new Ticket { Title = "Synchronisation temps réel via SignalR", Status = TicketStatus.Todo },
            new Ticket { Title = "Authentification et rôles", Status = TicketStatus.Todo });

        db.SaveChanges();
    }
}
