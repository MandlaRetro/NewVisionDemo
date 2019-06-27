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
            if (!ModelState.IsValid) return new BadRequestObjectResult("Modelstate invalid");
            try {
                var articles = context.Articles.OrderByDescending(x => x.UploadDate);
                if (articles.Count() == 0) return new OkObjectResult("No articles");
                else return new OkObjectResult(articles);
            } catch (Exception) {
                return new BadRequestObjectResult("Something went wrong");
            }
        }

        [HttpPost("postarticle")]
        public IActionResult PostArticle(Article article)
        {
            if (!ModelState.IsValid) return new BadRequestObjectResult("Modelstate invalid");
            if (article == null) return new BadRequestObjectResult("cannot post null data");
            try {
                article.UploadDate = DateTime.Now;
                context.Articles.Add(article);
                context.SaveChanges();
            } catch (Exception) {
                return new BadRequestObjectResult("Error uploading article");
            }

            return new OkObjectResult("Succesfully posted article");
        }
    }
}