using System.ComponentModel.DataAnnotations;
using VideoNews.Models.Enum;

namespace VideoNews.Models.Post;

public class PostVideos
{
    [Key] public long Id { get; set; }

    [Required] public long PostId { get; set; }
    [Required] public Post Post { get; set; } = null!;
    
    public string? VideoUrl { get; set; } = null!;
    public string? VideoId { get; set; } = null!;
    public VideoType VideoType { get; set; }
}