using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoNews.Data;

namespace VideoNews.ViewComponents;

public class RelatedNewsViewComponent : ViewComponent
{
    private readonly ApplicationDbContext _context;

    public RelatedNewsViewComponent(ApplicationDbContext context) => _context = context;

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var posts = await _context
            .Posts
            .OrderByDescending(p => p.CreatedAt)
            .Take(10).ToListAsync();
        
        return View(posts);
    }
}