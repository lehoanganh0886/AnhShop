namespace AnhShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private AnhShopDbContext dbContext;

        public AnhShopDbContext Init()
        {
            return dbContext ?? (dbContext = new AnhShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}