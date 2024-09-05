using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;

public class BlogPostController : Controller {
    private readonly BlogContext _context;

    public BlogPostController(BlogContext context) {
        _context = context;
    }
    public IActionResult Index() {
        var posts = _context.BlogPosts.ToList();
        return View(posts);
    }
}
