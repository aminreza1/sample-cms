using ContentManagementSystem.App.GlobalResults;
using ContentManagementSystem.Controllers.Article.DTOs;

namespace ContentManagementSystem.Repositories.Interfaces
{
    public interface IArticleRepo
    {
        RepoResult<IEnumerable<ArticleSearchDTO>> GetAllArticles(int page);
        RepoResult CreateArticle(ArticleCreateDTO input);
    }
}
