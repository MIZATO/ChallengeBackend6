using AutoMapper;
using ChallengeBackend6.Data.Dtos;
using ChallengeBackend6.Models;

namespace ChallengeBackend6.Profiles
{
    public class TutorProfile: Profile
    {
        public TutorProfile() 
        {
            CreateMap<CreateTutorDto, Tutor>();
            CreateMap<UpdateTutorDto, Tutor>();
            CreateMap<Tutor, ReadTutorDto>();
        }
    }
}
