using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Profile.Interface;
using Profile.dtos;

namespace Profile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService) {
            _personService=personService;
        
        }
        [HttpPost]
        public async Task<ActionResult<PersonResponse>> Creatuser(PersonRequest personRequest) { 

            PersonResponse result = await _personService.CreateAsync(personRequest);

            return Ok(result);
        }
    }
}
