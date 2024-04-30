using Microsoft.EntityFrameworkCore;

namespace CQRSDesignPattern.Dal
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Server=ITV10VM-MURATK;initial catalog=CqrsDb;TrustServerCertificate=True;User ID=sa;password=");

        }

        public DbSet<Product> Products { get; set; }
    }
}
