using System;

namespace BanHangT.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BanHangTDbContext Init();
    }
}