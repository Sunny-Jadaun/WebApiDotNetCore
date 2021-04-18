using System.Collections.Generic;
using System.Linq;
using myApiDotnetcore.Models;

namespace myApiDotnetcore.Services.CharacterServices
{
    public class CharacterServices : ICharacterServices
    {
        private static List<Characters> characters= new List<Characters> {
            new Characters(),
            new Characters{ id=1,name="Raju"},
            new Characters { id=2,strength= 50, knight=RpgClass.terros}
        };
        public List<Characters> GetAllCharacter(){
            return characters;
        }
        public Characters GetCharacterById(int id){
           return characters.FirstOrDefault(c=> c.id==id);
        }
        public List<Characters> AddCharacter(Characters newCharacter){
            characters.Add(newCharacter);
            return characters;
        }
    }
}