using Microsoft.AspNetCore.Mvc;
using VaegtApi;

namespace VægtTracker___Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeightController : ControllerBase
    {
        private readonly WeightRepository _repo;

        public WeightController(WeightRepository repo)
        {
            _repo = repo;
        }

        // Henter alle gemte vægte
        [HttpGet]
        public IActionResult GetWeight()
        {
            return Ok(_repo.Latest);
        }

        // Pi'en sender hertil: husk kun tallet
        [HttpPost]
        public IActionResult AddWeight([FromBody] double weight)
        {
            _repo.Latest = weight;
            return Ok(weight);
        }

        // Knappen kalder denne: gem vægten
        [HttpPost("save")]
        public IActionResult SaveWeight()
        {
            return Ok(_repo.Add(new Weight { Gram = _repo.Latest }));
        }
    }
}