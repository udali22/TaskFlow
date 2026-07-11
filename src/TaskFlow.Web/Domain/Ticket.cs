namespace TaskFlow.Web.Domain;

public class Ticket
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public TicketStatus Status { get; set; } = TicketStatus.Todo;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
