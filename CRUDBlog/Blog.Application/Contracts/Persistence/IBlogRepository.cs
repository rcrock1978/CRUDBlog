using Blog.Domain;

namespace Blog.Application.Contracts.Persistence
{
    public interface IBlogRepository : IGenericRepository<BlogPost>
    {
    }
}
