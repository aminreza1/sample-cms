namespace ContentManagementSystem.Controllers.Article.DTOs
{
    public class ArticleCreateDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsPublished { get; set; }
    }
}
