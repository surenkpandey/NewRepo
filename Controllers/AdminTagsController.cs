using Blog.Data;
using Blog.Models.ViewModels;
using Blog.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
	public class AdminTagsController : Controller
	{
        private readonly BlogDbContext blogDbContext;

        public AdminTagsController(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }
        [HttpGet]
		public IActionResult Add()
		{
			return View();
		}
		
		[HttpPost]
		[ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            // Mapping AddTagRequest to get Tag domain model
            var tag = new Tag
            {
            Name = addTagRequest.Name,
            DisplayName = addTagRequest.DisplayName,
            };

            blogDbContext.Tags.Add(tag);
            blogDbContext.SaveChanges();
            return View("Add");
        }

    }
}
