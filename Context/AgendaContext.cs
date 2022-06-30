using Agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Contato>().ToTable("contato");
            modelBuilder.Entity<Contato>() //so faz onde tem FK
                .HasOne(e => e.Endereco) // hasone - 1 contato tem 1 endereço 
                .WithMany(e => e.Contato)// has many(muito) - q endereço tem varios contatos
                .HasForeignKey(e=>e.Endereco_Id); //campo da FK

            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Endereco>() //so faz onde tem FK
               .HasOne(e => e.UF) // hasone - 1 contato tem 1 endereço 
               .WithMany(e => e.Endereco)// has many(muito) - q endereço tem varios contatos
               .HasForeignKey(e => e.UF_id); //campo da FK
                                             //Linq Lambda

            //modelBuilder.Entity<Usuario>().ToTable("usuario");

        }

        //faz o vinculo com o banco de dados( sao as classes criadas)
        //definir a comunicação com as tabelas do banco de dados
        //faz importação dos models.
        public DbSet<Contato> Contato { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<UF> UF { get; set; }

       
        
    }
}
