using ContentManagementSystem.App.GlobalDTOs;

namespace ContentManagementSystem.Controllers.Article.DTOs
{
    public class ArticleSearchDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Abbr { get; set; }
        public IdTitlePair<int> Author { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
