using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebComprasIdentity.Models;

namespace WebComprasIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Compra> Compras { get; set; }
    }
}
