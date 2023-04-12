using AutoMapper;
using ChallengeBackend6.Data.Dtos;
using ChallengeBackend6.Models;

namespace ChallengeBackend6.Profiles
{
    public class PetProfile : Profile 
    {
        public PetProfile() 
        {
            CreateMap<CreatePetDto, Pet>();
            CreateMap<UpdatePetDto, Pet>();
            CreateMap<Pet, ReadPetDto>();

        }

    }
}
