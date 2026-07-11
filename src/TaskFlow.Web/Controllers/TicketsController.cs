using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskFlow.Web.Data;

namespace TaskFlow.Web.Controllers;

public class TicketsController : Controller
{
    private readonly AppDbContext _db;

    public TicketsController(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        var tickets = await _db.Tickets
            .OrderBy(t => t.Id)
            .ToListAsync();

        return View(tickets);
    }
}
