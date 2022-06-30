namespace Agenda.Models
{
    public class UF
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }

        #region Navigation Properties
        
        public virtual List<Endereco> Endereco { get; set; }
        #endregion
    }
}
