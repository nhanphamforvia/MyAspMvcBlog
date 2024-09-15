using Microsoft.AspNetCore.Mvc;
using MyAspMvcPost.Data;
using MyAspMvcPost.DTOs;
using MyAspMvcPost.Entities;

namespace MyAspMvcPost.Controllers;

public class PostsController : Controller
{
    private readonly ApplicationDbContext _db;
    
    public PostsController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        List<Post> posts = _db.Posts.ToList();
        return View(posts);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CreatePostDTO createPostDTO)
    {
        Post newPost = new Post {
            Title = createPostDTO.Title,
            Content = createPostDTO.Content,
            Image = createPostDTO.Image ?? string.Empty,
            Created = createPostDTO.Created == DateTime.MinValue ? DateTime.Now : createPostDTO.Created,
            ReadTimeMinute = createPostDTO.Content.Split(' ').Length / 200,
            UserId = 1
        };

        _db.Posts.Add(newPost);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
}
