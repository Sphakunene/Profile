using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Profile.Interface;
using Profile.Model;

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
        public async Task<ActionResult<Person>> Creatuser(Person person) { 

            Person result = await _personService.CreateAsync(person);

            return Ok(result);
        }
    }
}
