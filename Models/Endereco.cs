namespace Agenda.Models
{
    public class Endereco
    {
        #region Properties 
        public int Id { get; set; }
        public string? Logradouro { get; set; }//null
        public int? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }

        public int UF_id { get; set; }
        #endregion

        #region Navigation Properties
        public virtual UF UF { get; set; }

        public virtual List<Contato> Contato { get; set; }  //um endereço tem varios contatos
        #endregion

        //1 contato pode ter um endereço, 1 endereço tem varios contato.
        //1:1
        // 1 endereço  pode ter 1 UF , 1 UF pode ter varios endereços
        //1:n
    }
}
