namespace BanHangT.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BanHangTDbContext dbContext;

        public BanHangTDbContext Init()
        {
            return dbContext ?? (dbContext = new BanHangTDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}