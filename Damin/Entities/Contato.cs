using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Contato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public bool Status { get; set; }
        [Required, MaxLength(100)]
        public string Telefone { get; set; }

        [Required, ForeignKey(nameof(Usuario))]
        public long FkIdUsuario { get; set; }
    }
}