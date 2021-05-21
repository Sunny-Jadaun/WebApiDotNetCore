using System.Collections.Generic;
using System.Threading.Tasks;
using myApiDotnetcore.Models;
using myApiDotnetcore.DTOS.CharDto;
namespace myApiDotnetcore.Services.CharacterServices
{
    public interface ICharacterServices
    {
         Task<ServiceResponse< List<GetCharacterDto>>> GetAllCharacter();
         Task<ServiceResponse< GetCharacterDto>> GetCharacterById(int id);
         Task<ServiceResponse< List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
         Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacter);
         
         
    }
}