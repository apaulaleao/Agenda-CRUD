using Agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        //faz o vinculo com o banco de dados( sao as classes criadas)
        //definir a comunicação com as tabelas do banco de dados
        //faz importação dos models.
        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        
    }
}
