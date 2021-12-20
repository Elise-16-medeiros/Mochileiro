using System.ComponentModel.DataAnnotations;

namespace Mochileiro.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        [StringLength(100)]
        public string Mensagem { get; set; }
    }
}
