using BanHangT.Data.Infrastructure;
using BanHangT.Model.Models;

namespace BanHangT.Data.Repository
{
    public interface IFooterRepository : IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}