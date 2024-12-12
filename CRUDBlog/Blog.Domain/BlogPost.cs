using Blog.Domain.Common;

namespace Blog.Domain
{
    public class BlogPost : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BannerImagePath { get; set; }
        public string Content { get; set; }
        public BlogStatus Status { get; set; }
        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
    }
}
