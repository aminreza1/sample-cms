using System.ComponentModel.DataAnnotations;

namespace ContentManagementSystem.Models
{
    public class User
    {
        public User()
        {
            Articles = new List<Article>();
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsBlock { get; set; }
        public IEnumerable<Article> Articles { get; set; }
    }
}
