using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required, MaxLength(100)]
        public string Senha { get; set; }
        [Required, MaxLength(3)]
        public string Role { get; set; }
    }
}
