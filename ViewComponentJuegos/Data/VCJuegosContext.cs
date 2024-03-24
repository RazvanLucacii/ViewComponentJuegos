using Microsoft.EntityFrameworkCore;
using ViewComponentJuegos.Models;

namespace ViewComponentJuegos.Data
{
    public class VCJuegosContext : DbContext
    {
        public VCJuegosContext(DbContextOptions<VCJuegosContext> options): base(options) { }

        public DbSet<Juego> Juegos { get; set; }

        public DbSet<Genero> Generos { get; set; }
    }
}
