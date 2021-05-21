using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myApiDotnetcore.DTOS.CharDto;
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
        public async Task<IActionResult> get(){
            return Ok(await _characterservices.GetAllCharacter());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getFirst(int id){
            return Ok(await _characterservices.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> addData(AddCharacterDto newCharacter){

            return Ok(await _characterservices.AddCharacter(newCharacter));
        }

        [HttpPut]
         public async Task<IActionResult> updateCharacter(UpdateCharacterDto updateCharacter){

            ServiceResponse<GetCharacterDto> serviceResponse = await _characterservices.UpdateCharacter(updateCharacter);
            if(serviceResponse.data==null)
            {
                return NotFound(serviceResponse);
            }
                return Ok(serviceResponse);
        }
    }
}