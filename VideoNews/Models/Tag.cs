namespace VideoNews.Models;

public class Tag : BaseModel
{
    public string? Description { get; set; }
    public string? Icon { get; set; }

    public IList<Post.Post>? Posts { get; set; }
}