
using Microsoft.AspNetCore.Mvc;
using NewVisionAPIDemo.Models;

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

        [HttpGet("")]
        public IActionResult GetArticlesByAuthor(string authorName) {

        }
    }
}