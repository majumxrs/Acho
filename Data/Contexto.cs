using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<UsuariosModel> Usuario { get; set; }

        public DbSet<ObservacoesModel> Observacoes { get; set; }

        public DbSet<AnimaisModel> Animais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuariosMap());
            modelBuilder.ApplyConfiguration(new ObservacoesMap());
            modelBuilder.ApplyConfiguration(new AnimaisMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
