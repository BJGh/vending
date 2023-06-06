using Microsoft.EntityFrameworkCore;

namespace vending.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Coin> Coins { get; set; }
        public DbSet<CoinModel> CoinModels { get; set; }
        public DbSet<DeliveryEntityModel> DeliveryModels { get; set;}
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<ServingModel> ServingModels { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
          : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
