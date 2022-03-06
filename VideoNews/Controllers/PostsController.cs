#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoNews.Data;

namespace VideoNews.Controllers
{
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PostsController(ApplicationDbContext context) => _context = context;

        // GET: Posts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context
                .Posts.Include(p => p.SubCategory)
                .OrderByDescending(p => p.CreatedAt);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Posts/Details/slug-name
        public async Task<IActionResult> Details(string slug)
        {
            if (slug == null) return NotFound();

            var post = await _context.Posts
                .Include(p => p.SubCategory)
                .FirstOrDefaultAsync(m => m.Slug == slug);

            if (post == null) return NotFound();

            return View(post);
        }
    }
}