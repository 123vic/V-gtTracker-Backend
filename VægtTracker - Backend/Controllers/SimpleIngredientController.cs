using Backend_Classes.Interfaces;
using Backend_Classes.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VægtTracker___Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleIngredientController : ControllerBase
    {
        ISimpelIngredientRepository _repository;

        public SimpleIngredientController(ISimpelIngredientRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<SimpleIngredientController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public ActionResult<IEnumerable<SimpelIngredient>> Get()
        { 
            return Ok(_repository.GetAll());
        }

        //GET 

        [HttpGet("/getfood/{searchterm}")]
        public SimpelIngredient Get(string searchterm) 
        { 
            return _repository.GetItemByName(searchterm);
        }

        // GET api/<SimpleIngredientController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SimpleIngredientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SimpleIngredientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SimpleIngredientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
