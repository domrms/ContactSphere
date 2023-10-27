using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Contatos
    {
        [JsonIgnore]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [JsonIgnore]
        [Required]
        public bool Status { get; set; }

        [Required, MaxLength(100)]
        public string Telefone { get; set; }

        [JsonIgnore]
        [Required, ForeignKey(nameof(Usuarios))]
        public long FkIdUsuario { get; set; }
    }
}