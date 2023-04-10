using AutoMapper;
using ChallengeBackend6.Data.Dtos;
using ChallengeBackend6.Models;

namespace ChallengeBackend6.Profiles
{
    public class AbrigoProfile: Profile
    {
        public AbrigoProfile()
        {
            CreateMap<CreateAbrigoDto, Abrigo>();
            CreateMap<UpdateAbrigoDto, Abrigo>();
            CreateMap<Abrigo, ReadAbrigoDto>();

        }

    }
}
