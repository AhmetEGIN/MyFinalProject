using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // Context nesnesi db tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Bu metot bizim projemiz hangi veri tabanı ile ilişkili olduğunu belirteceğimiz yer.
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;Database = Northwind; Trusted_Connection = true");  // \ işaretini kullanırken başına @ işareti koyduğumuzda \ işaretini normal kullan demek
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
