using System.ComponentModel.DataAnnotations;

namespace MyAspMvcPost.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Title is required!")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Content is required!")]
        public string Content { get; set; } = string.Empty;

        [Required(ErrorMessage = "Image is required!")]
        public string Image { get; set; } = string.Empty;

        [Required(ErrorMessage = "Created is required!")]
        public DateTime Created { get; set; } = DateTime.Now;

        public int UserId { get; set; }

        public int ReadTimeMinute { get; set; }
    }
}