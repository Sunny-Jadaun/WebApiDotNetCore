using AutoMapper;
using myApiDotnetcore.Models;

namespace myApiDotnetcore.DTOS.CharDto
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Characters, GetCharacterDto>();
            CreateMap<AddCharacterDto, Characters>();
        }
    }
}