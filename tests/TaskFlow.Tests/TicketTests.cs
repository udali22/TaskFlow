using TaskFlow.Web.Domain;

namespace TaskFlow.Tests;

public class TicketTests
{
    [Fact]
    public void NewTicket_StartsInTodoStatus()
    {
        var ticket = new Ticket { Title = "Nouveau ticket" };

        Assert.Equal(TicketStatus.Todo, ticket.Status);
    }

    [Fact]
    public void NewTicket_HasCreationTimestampInUtc()
    {
        var ticket = new Ticket { Title = "Nouveau ticket" };

        Assert.Equal(DateTimeKind.Utc, ticket.CreatedAt.Kind);
    }
}
