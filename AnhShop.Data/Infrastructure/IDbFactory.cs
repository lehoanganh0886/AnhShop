using System;

namespace AnhShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        AnhShopDbContext Init();
    }
}