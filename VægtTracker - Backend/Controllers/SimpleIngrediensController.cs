using Backend_Classes.Interfaces;
using Backend_Classes.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VægtTracker___Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleIngrediensController : ControllerBase
    {
        ISimpelIngredientRepository _repository;

        public SimpleIngrediensController(ISimpelIngredientRepository repository)
        {
            _repository = repository;
        }
        
        // GET: api/<SimpleIngrediensController>
        [HttpGet]
        public IEnumerable<SimpelIngredient> Get()
        {
            
        }

        // GET api/<SimpleIngrediensController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SimpleIngrediensController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SimpleIngrediensController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SimpleIngrediensController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
