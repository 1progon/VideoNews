using System.ComponentModel.DataAnnotations;

namespace VideoNews.Models.Post;

public class SubCategoryPosts : BaseModel
{
    [Key] public override long Id { get; set; }

    public long CategoryId { get; set; }
    public CategoryPosts Category { get; set; } = null!;

    public IList<Post>? Posts { get; set; }
}