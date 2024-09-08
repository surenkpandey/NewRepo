using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
