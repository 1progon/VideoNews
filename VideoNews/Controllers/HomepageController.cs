using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoNews.Data;

namespace VideoNews.Controllers;

public class HomepageController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomepageController(ApplicationDbContext context) => _context = context;

    public async Task<IActionResult> Index()
    {
        var posts = await _context
            .Posts.OrderByDescending(p => p.CreatedAt)
            .Take(30)
            .ToListAsync();
        return View(posts);
    }
}