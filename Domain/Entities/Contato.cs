using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Contato
    {
        [Key]
        public long Id { get; private set; }
        [Required, MaxLength(100)]
        public string Nome { get; private set; }
        [Required, MaxLength(100)]
        public string Email { get; private set; }
        [Required]
        public bool Status { get; private set; }
        [Required, ForeignKey(nameof(Usuario))]
        public long FkIdUsuario { get; private set; }
    }
}
