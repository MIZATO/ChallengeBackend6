using System.ComponentModel.DataAnnotations;

namespace ChallengeBackend6.Data.Dtos
{
    public class ReadPetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AbrigoId { get; set; }
        public int Descricao { get; set; }
        public bool Adocao { get; set; }
        public string? Idade { get; set; }
        public string Cidade { get; set; }
        public string ImgPet { get; set; }
        public string Especie { get; set; }
    }
}
