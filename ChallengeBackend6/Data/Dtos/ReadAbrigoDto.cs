﻿namespace ChallengeBackend6.Data.Dtos
{
    public class ReadAbrigoDto : ReadTutorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Cidade { get; set; }
        public int PermissaoCadastroPet { get; set; }
    }
}
