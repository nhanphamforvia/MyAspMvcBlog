using Microsoft.AspNetCore.Mvc;

namespace MyAspMvcBlog.Controllers;

public class BlogsController : Controller
{
    private readonly ILogger<BlogsController> _logger;

    public BlogsController(ILogger<BlogsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
