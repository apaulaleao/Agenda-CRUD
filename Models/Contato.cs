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

        #region Navigation Properties

        public int Endereco_Id { get; set; } // essa coluna esta na tabela FK

        public virtual Endereco Endereco { get; set; }
        #endregion
    }
}
