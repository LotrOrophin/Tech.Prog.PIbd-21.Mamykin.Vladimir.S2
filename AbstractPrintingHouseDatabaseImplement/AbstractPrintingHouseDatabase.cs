
using AbstractPrintingHouseDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace AbstractPrintingHouseDatabaseImplement
{
    public class AbstractPrintingHouseDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2VLTMI2\SQLEXPRESS;Initial Catalog=PrintingHouse3Database;Integrated Security=True;MultipleActiveResultSets=True;");

            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<OfficeComponent> Components { set; get; }
        public virtual DbSet<PrintingProduct> Products { set; get; }
        public virtual DbSet<ProductOfficeComponent> ProductComponents { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
    }
}

    