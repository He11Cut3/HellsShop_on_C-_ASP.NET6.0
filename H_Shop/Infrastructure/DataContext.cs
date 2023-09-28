using Microsoft.EntityFrameworkCore;
using H_Shop.Models;

namespace H_Shop.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<HShopProduct> HShopProducts { get; set; }

        public DbSet<HShopUser> HShopUsers { get; set; }
    }
}
