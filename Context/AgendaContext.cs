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
        public DbSet<Contato> Contatos { get; set; }
        
    }
}
