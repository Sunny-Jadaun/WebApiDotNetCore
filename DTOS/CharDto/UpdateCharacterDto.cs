using myApiDotnetcore.Models;

namespace myApiDotnetcore.DTOS.CharDto
{
    public class UpdateCharacterDto
    {
        public int id {get; set;}
        public string name {get;set;}
        public int strength {get;set;} = 100;

        public RpgClass knight{get;set;}=RpgClass.knight;
    }
}