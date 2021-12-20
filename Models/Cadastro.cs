using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mochileiro.Models
{
    public class Cadastro
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Id_Contato")]
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereço { get; set; }
        public string UF { get; set; }
        public string Senha { get; set; }
    }
}
