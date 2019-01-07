namespace Zircon.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class ZirconDbContext : IdentityDbContext<User>
    {
        public ZirconDbContext(DbContextOptions<ZirconDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<GiftCard> GiftCards { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductOrders> ProductOrderses { get; set; }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Address>()
                .HasKey(a => a.Id);

            builder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique(); ;

            builder.Entity<GiftCard>()
                .HasIndex(g => g.Code)
                .IsUnique(); ;

            builder.Entity<Product>()
                .HasMany(p => p.Orders)
                .WithOne(o => o.Product)
                .HasForeignKey(p => p.ProductId);

            builder.Entity<Order>()
                .HasMany(o => o.Products)
                .WithOne(p => p.Order)
                .HasForeignKey(o => o.OrderId);

            builder.Entity<ProductOrders>()
                .HasKey(po => new { po.ProductId, po.OrderId });

            base.OnModelCreating(builder);
        }
    }
}
