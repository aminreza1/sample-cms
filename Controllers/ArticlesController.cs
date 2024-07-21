using ContentManagementSystem.App;
using ContentManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContentManagementSystem.Controllers
{
    [Route("articles")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ArticlesController(AppDbContext context)
        {
            _db = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Article>> Search(int page) // R 
        {
            try
            {
                var articles = _db.Articles
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * 10)
                .Take(10)
                .ToList();

                return Ok(articles);
            }
            catch (Exception ex)
            {
                return Problem(ex.ToString());
            }
            
        }

        [HttpGet("{id}")]
        public ActionResult Read(int id)  // R
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Create(object input) // C
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, object input) // U
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete() // D
        {
            return Ok();
        }
    }
}
