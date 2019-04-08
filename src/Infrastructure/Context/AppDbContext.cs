using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
   public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Produto> Produto { set; get; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json configurado
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConectionConfig());

            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Database=eDrinkShop.Web-Db;;Integrated Security=False;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            return strCon;
        }

    }
}
