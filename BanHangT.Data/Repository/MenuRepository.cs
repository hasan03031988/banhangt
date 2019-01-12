using BanHangT.Data.Infrastructure;
using BanHangT.Model.Models;

namespace BanHangT.Data.Repository
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}