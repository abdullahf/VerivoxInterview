using Microsoft.AspNetCore.Mvc;
using Verivox_Interview.Services;

namespace Verivox_Interview.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeriffController : Controller
    {
        private readonly ILogger<TeriffController> _logger;
        private readonly ITeriffService _teriffServicer;

        public TeriffController(ITeriffService teriffServicer, ILogger<TeriffController> logger)
        {
            _teriffServicer = teriffServicer;
            _logger = logger;
        }

        [HttpGet]
        [Route("compare/{annualComsumption}")]
        public IActionResult Comparision(int annualComsumption)
        {
            if (annualComsumption < 0)
            {
                var message = $"Comparision Error: Invalid argument ({annualComsumption})";
                _logger.LogError(message);
                return BadRequest(message);

            }

            var teriffs = _teriffServicer.GetCostModel(annualComsumption);

            return Ok(teriffs);
        }
    }
}