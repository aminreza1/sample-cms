using System.ComponentModel.DataAnnotations;

namespace ContentManagementSystem.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public bool IsPublished { get; set; }
        public DateTime CreatedAt { get; set; }
        public User Author { get; set; }
    }
}
