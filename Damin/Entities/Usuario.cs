using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Usuario
    {
        [Key]
        public long Id { get; private set; }
        [Required, MaxLength(100)]
        public string Username { get; private set; }
        [Required, MaxLength(100)]
        public string Senha { get; private set; }
        [Required, MaxLength(3)]
        public string Role { get; private set; }
    }
}
