using Blog.Application.Models.Identity;

namespace Blog.Application.Contracts.Identity
{
    public interface IUserService
    {
        Task<List<Author>> GetAuthors();
        Task<Author> GetAuthor(string userId);
        public string UserId { get; }
    }
}
