using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using myApiDotnetcore.Models;
using myApiDotnetcore.Services.CharacterServices;

namespace myApiDotnetcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class showCharactersController :ControllerBase
    {   
        private readonly ICharacterServices _characterservices;
        public showCharactersController(ICharacterServices characterServices){
        _characterservices=characterServices;
        }

        [Route("getall")]
        public IActionResult get(){
            return Ok(_characterservices.GetAllCharacter());
        }
        [HttpGet("{id}")]
        public IActionResult getFirst(int id){
            return Ok(_characterservices.GetCharacterById(id));
        }

        [HttpPost]
        public IActionResult addData(Characters newCharacter){

            return Ok(_characterservices.AddCharacter(newCharacter));
        }
    }
}