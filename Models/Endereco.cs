namespace Agenda.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string? Logradouro { get; set; }//null
        public int? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }

        //1 contato pode ter um endereço, 1 endereço tem varios contato.
            //1:1
            // 1 endereço  pode ter 1 UF , 1 UF pode ter varios endereços
            //1:n
    }
}
