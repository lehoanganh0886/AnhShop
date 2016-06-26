using AnhShop.Model.Models;
using System.Data.Entity;

namespace AnhShop.Data
{
    public class AnhShopDbContext : DbContext
    {
        public AnhShopDbContext() : base("AnhShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false; //load bang cha khong tu dong load them bang con
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategorys { set; get; }
        public DbSet<PostTag> PostTag { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }
        // chay khi khoi tao entity framework
        // trong quá trình làm. ghi đè 1 phương thức
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}