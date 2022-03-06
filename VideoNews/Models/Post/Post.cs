using System.ComponentModel.DataAnnotations;
using VideoNews.Models.Enum;

namespace VideoNews.Models.Post;

public class Post : BaseModel
{
    [Key] public override long Id { get; set; }

    public string Description { get; set; } = null!;
    public string? Article { get; set; } = null!;
    public string? VideoUrl { get; set; } = null!;
    public string? VideoId { get; set; } = null!;
    public VideoType VideoType { get; set; }


    public string? Image { get; set; }

    public IList<Tag>? Tags { get; set; }
    public IList<PostVideos>? PostVideos { get; set; }

    public long? SubCategoryId { get; set; }
    public SubCategoryPosts? SubCategory { get; set; }
}