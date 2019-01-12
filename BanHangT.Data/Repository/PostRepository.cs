using BanHangT.Data.Infrastructure;
using BanHangT.Model.Models;

namespace BanHangT.Data.Repository
{
    public interface IPostRepository : IRepository<Post>
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}