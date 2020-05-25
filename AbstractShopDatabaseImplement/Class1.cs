
using AbstractPrintingHouseDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
namespace AbstractShopDatabaseImplement
{
    public class AbstractShopDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=HOME\SQLEXPRESS;Initial Catalog=PrintingHouseDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
 public virtual DbSet<OfficeComponent> Components { set; get; }
        public virtual DbSet<PrintingProduct> Products { set; get; }
        public virtual DbSet<ProductOfficeComponent> ProductComponents { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
    }
}

