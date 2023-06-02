using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MyDbContext:DbContext
    {
       public DbSet<Car> Cars { get; set; }
       public DbSet<Customer> Customers { get; set; }
       public DbSet<Part> Parts { get; set; } 
       public DbSet<Sale> Sales { get; set; }
       public DbSet<Supplier> Suppliers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\ProjectModels;Initial Catalog=CarStroeDb");
        }
       

    }
}