using System.ComponentModel.DataAnnotations;

namespace ChallengeBackend6.Data.Dtos
{
    public class CreateAbrigoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MaxLength(50, ErrorMessage = "O Nome nao pode exceder 50 caracteres")]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Tem que ter @")]
        public string Email { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "apenas 0 para inativo é 1 para ativo")]
        [Range(0, 1)]
        public int PermissaoCadastroPet { get; set; }
    }
}
