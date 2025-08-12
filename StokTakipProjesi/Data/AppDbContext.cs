using Microsoft.EntityFrameworkCore;
using stokprojesi2.Models;
using StokTakipProjesi.Models;

namespace stokprojesi2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Recete> Receteler { get; set; }
    }
}
