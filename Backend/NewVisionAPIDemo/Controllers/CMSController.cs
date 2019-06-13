using Microsoft.AspNetCore.Mvc;
using NewVisionAPIDemo.Models;
using System;
using System.Linq;

namespace NewVisionAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMSController : ControllerBase
    {
        private ModelsContext context;

        public CMSController(ModelsContext context) {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetArticles(string authorName) {
            if (!ModelState.IsValid) return new BadRequestObjectResult("Error");
            try {
                var articles = context.Articles.OrderByDescending(x => x.UploadDate);
                if (articles.Count() == 0) return new OkObjectResult("No articles");
                else return new OkObjectResult(articles);
            } catch (Exception) {
                return new BadRequestObjectResult("Something went wrong");
            }
        }
    }
}