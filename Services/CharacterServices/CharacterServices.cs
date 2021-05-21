using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myApiDotnetcore.Models;
using myApiDotnetcore.DTOS.CharDto;
using AutoMapper;
using System;

namespace myApiDotnetcore.Services.CharacterServices
{
    public class CharacterServices : ICharacterServices
    {
        private static List<Characters> characters= new List<Characters> {
            new Characters(),
            new Characters{ id=1,name="Raju"},
            new Characters { id=2,strength= 50, knight=RpgClass.terros}
        };

        private readonly IMapper _mapper;
        public CharacterServices(IMapper mapper){
            _mapper=mapper;
        }
        public async Task<ServiceResponse< List<GetCharacterDto>>> GetAllCharacter(){
            ServiceResponse<List<GetCharacterDto>> serviceResponse=new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.data=(characters.Select(c=> _mapper.Map<GetCharacterDto>(c))).ToList();
            return  serviceResponse;
        }
        public async Task<ServiceResponse< GetCharacterDto>> GetCharacterById(int id){
            ServiceResponse<GetCharacterDto> serviceResponse=new ServiceResponse<GetCharacterDto>();
           serviceResponse.data= _mapper.Map<GetCharacterDto>(characters.FirstOrDefault(c=> c.id==id));
           return serviceResponse;
        }
        public async Task<ServiceResponse< List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter){
            ServiceResponse<List<GetCharacterDto>> serviceResponse=new ServiceResponse<List<GetCharacterDto>>();
            Characters character= _mapper.Map<Characters>(newCharacter);
            character.id= characters.Max(c=> c.id)+1;
            characters.Add(character);
             serviceResponse.data=(characters.Select(c=> _mapper.Map<GetCharacterDto>(c))).ToList();
             return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacter)
        {
            ServiceResponse<GetCharacterDto> serviceResponse=new ServiceResponse<GetCharacterDto>();
            try{
            Characters character=characters.FirstOrDefault(c=> c.id==updateCharacter.id);
            character.name=updateCharacter.name;
            character.knight=updateCharacter.knight;
            character.strength=updateCharacter.strength;

            serviceResponse.data=_mapper.Map<GetCharacterDto>(character);
            }
            catch(Exception ex)
            {
                serviceResponse.success=false;
                serviceResponse.EMassage= ex.Message;
            }
            return serviceResponse;
        }
    }
}