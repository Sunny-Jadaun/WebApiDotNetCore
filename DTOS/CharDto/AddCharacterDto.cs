using myApiDotnetcore.Models;

namespace myApiDotnetcore.DTOS.CharDto
{
    public class AddCharacterDto
    {
      
        public string name {get;set;}
        public int strength {get;set;} = 100;

        public RpgClass knight{get;set;}=RpgClass.knight;
    }
}