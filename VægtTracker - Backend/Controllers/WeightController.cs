using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VægtTracker___Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeightController : ControllerBase
    {
        private static double _weightGrams = 0;
        [HttpGet]
        public IActionResult GetWeight()
        {
            return Ok(_weightGrams);
        }

        [HttpPost]
        public IActionResult AddWeight([FromBody] double weight)
        {
            _weightGrams = weight;
            return Ok(_weightGrams);
        }
    }
}
