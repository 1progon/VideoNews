using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VideoNews.Models;
using VideoNews.Models.Post;
using VideoNews.Models.User;

namespace VideoNews.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Posts
    public DbSet<CategoryPosts> CategoryPosts { get; set; } = null!;
    public DbSet<SubCategoryPosts> SubCategoryPosts { get; set; } = null!;
    public DbSet<Post> Posts { get; set; } = null!;
    public DbSet<PostVideos> PostVideos { get; set; } = null!;

    // Tag
    public DbSet<Tag> Tags { get; set; } = null!;
}