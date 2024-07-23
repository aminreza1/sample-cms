using ContentManagementSystem.App;
using ContentManagementSystem.Controllers.Article.DTOs;
using Models = ContentManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using ContentManagementSystem.Repositories.Interfaces;

namespace ContentManagementSystem.Controllers.Article
{
    [Route("articles")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepo _repo;

        public ArticlesController(IArticleRepo repository)
        {
            _repo = repository;
        }


        [HttpGet]
        public ActionResult<IEnumerable<ArticleSearchDTO>> Search(int page) // R 
        {
            var result = _repo.GetAllArticles(page);
            if (result.IsSuccess)
                return Ok(result.Data);
            return Problem(result.Details);
        }

        [HttpGet("{id}")]
        public ActionResult<Models.Article> Read(int id)  // R
        {
            return Ok();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(ArticleCreateDTO input) // C
        {
            //try
            //{

            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Models.Article input) // U
        {
            return Ok();
        }

        [HttpPut("{id}/similar")]
        public ActionResult Update(int id, int similarId) // U
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
