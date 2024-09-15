namespace MyAspMvcPost.DTOs;

public class CreatePostDTO
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public DateTime Created { get; set; } = DateTime.Now;
}