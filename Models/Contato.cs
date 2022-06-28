using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Column("email_principal")]
        public string Email { get; set; }
        public string Apelido { get; set; }
        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; } 
    }
}
