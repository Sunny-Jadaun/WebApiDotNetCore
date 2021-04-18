using myApiDotnetcore.Models;
namespace myApiDotnetcore.Models
{
    public class Characters
    {
        public int id {get; set;}
        public string name {get;set;}
        public int strength {get;set;} = 100;

        public RpgClass knight{get;set;}=RpgClass.knight;
    }
}