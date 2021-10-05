using Microsoft.EntityFrameworkCore;

namespace Gerenciador_de_espaçonaves_do_star_wars.Models
{
    class StarWarsContext : DbContext
    {
        public DbSet<Piloto> Pilotos { get; set; }
        public DbSet<Nave> Naves { get; set; }
        public DbSet<Planeta> Planetas { get; set; }
        public DbSet<Viagem> HistoricoViagens { get; set; }
        public string DbPath { get; private set; }

        public StarWarsContext()
        {
            DbPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Narde\Visual Studio\Projects\Gerenciador de espaçonaves do star wars\Gerenciador de espaçonaves do star wars\DataBase\StarWars.mdf;Integrated Security=True;Connect Timeout=30";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(DbPath);
    }
}
