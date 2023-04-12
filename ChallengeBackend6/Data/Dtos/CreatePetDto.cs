﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ChallengeBackend6.Data.Dtos
{
    public class CreatePetDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MaxLength(30, ErrorMessage = "O Nome nao pode exceder 30 caracteres")]
        public string Name { get; set; }
        [Required]
        public int AbrigoId { get; set; }
        [Required(ErrorMessage = "A descricao é obrigatória")]
        [MaxLength(50, ErrorMessage = "A Descricao nao pode exceder 50 caracteres")]
        [MinLength(10, ErrorMessage = "A Descricao nao pode ter menos 10 caracteres")]
        public int Descricao { get; set; }
        public bool Adocao { get; set; } = false;
        public string? Idade { get; set; }
        [Required(ErrorMessage = "O Cidade é obrigatório")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "A img do animal é obrigatória")]
        [Url(ErrorMessage = "Nao é uma Url Valida")]
        public string ImgPet { get; set; }
        [Required(ErrorMessage = "A Especie é obrigatória")]
        public string Especie { get; set; }
        public DateTime DataUpdate { get; set; }
    }
}
