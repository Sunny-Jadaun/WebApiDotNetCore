using System.Collections.Generic;
using myApiDotnetcore.Models;

namespace myApiDotnetcore.Services.CharacterServices
{
    public interface ICharacterServices
    {
         List<Characters> GetAllCharacter();
         Characters GetCharacterById(int id);
         List<Characters> AddCharacter(Characters newCharacter);
         
    }
}