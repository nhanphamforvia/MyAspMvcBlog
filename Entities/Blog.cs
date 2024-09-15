using System.ComponentModel.DataAnnotations;

namespace MyAspMvcBlog.Entities
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Title is required!")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Content is required!")]
        public string Content { get; set; } = string.Empty;
    }
}