using AutoMapper;
using ContentManagementSystem.App;
using ContentManagementSystem.App.GlobalResults;
using ContentManagementSystem.Controllers.Article.DTOs;
using ContentManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContentManagementSystem.Repositories
{
    public class ArticleRepo : IArticleRepo
    {
        private AppDbContext _db;
        private IMapper _mapper;
        public ArticleRepo(AppDbContext db,IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public RepoResult CreateArticle(ArticleCreateDTO input)
        {
            try
            {
                return RepoResult.Success();
            }
            catch (Exception ex)
            {
                return RepoResult.Error(ex.ToString());
            }
        }

        public RepoResult<IEnumerable<ArticleSearchDTO>> GetAllArticles(int page)
        {
            try
            {
                var articles = _db.Articles
                .Include(i => i.Author)
                .Where(x => x.IsPublished)
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * 10)
                .Take(10);

                var mappedArticle = _mapper.Map<IEnumerable<ArticleSearchDTO>>(articles);

                return RepoResult<IEnumerable<ArticleSearchDTO>>.Success(mappedArticle);
            }
            catch (Exception ex)
            {
                return RepoResult<IEnumerable<ArticleSearchDTO>>.Error(ex.ToString());
            }
        }
    }
}
