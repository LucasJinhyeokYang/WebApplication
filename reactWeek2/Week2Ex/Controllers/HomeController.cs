using Microsoft.AspNetCore.Mvc;
using Week2Ex.Models;
namespace Week2Ex.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            ViewBag.Title = "Home | Lucas's Lab 8";
            return View();
        }
        public string Test(string id){
            return id; 
        }

        public IActionResult Post()
        {
            Post post = new Post();
            post.Title = "My Blog Post";
            post.PostedDate = DateTime.Now;
            post.Author = "Jinhyeok Yang";
            post.Body = "My first post about ASP.NET MVC Core";
            return View(post);
        }

    }
}
