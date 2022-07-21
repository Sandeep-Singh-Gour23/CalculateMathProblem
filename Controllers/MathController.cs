using CalculateMathProblem.Domain;
using CalculateMathProblem.Filters;
using CalculateMathProblem.Service_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculateMathProblem.Controllers
{

   // [ServiceFilter(typeof(CalculateLogFilter))] // Controller level Filter
    [Route("api/[controller]")]
    [ApiController]

    public class MathController : ControllerBase
    {
        private readonly IMathService _mathService;
        private readonly ILogger<MathController> _logger;
        public MathController(IMathService mathService, ILogger<MathController> logger)
        {
            _mathService = mathService;
            _logger = logger;
        }

        [HttpPost]
        [Route("/logging")]
        public string logging(string msg, string leveloflog)
        {
            if (leveloflog == "debug")
            {
                _logger.LogDebug("This is a debug");
                return msg;
            }
            else if (leveloflog == "warning")
            {
                _logger.LogWarning("This is a Warnimg");
                return msg;
            }
            else if (leveloflog == "error")
            {
                _logger.LogError("This is an error");
                return msg;
            }
            return msg;
        }

        [ServiceFilter(typeof(CalculateLogFilter))]
        [HttpPost]
        [Route("/add")]
        public int Addition([FromBody] domain input)
        {
            return _mathService.add(input.number_1, input.number_2);
        }

        [ServiceFilter(typeof(CalculateLogFilter))]
        [HttpPost]
        [Route("/subtract")]
        public int Subtraction([FromBody] domain input)
        {

            return _mathService.subtract(input.number_1, input.number_2);
        }

        [ServiceFilter(typeof(CalculateLogFilter))]
        [HttpPost]
        [Route("/multiply")]
        public int Multiplication([FromBody] domain input)
        {
            return _mathService.multiply(input.number_1, input.number_2);
        }

        [ServiceFilter(typeof(CalculateLogFilter))]
        [HttpPost]
        [Route("/divide")]
        public int Division([FromBody] domain input)
        {
            return _mathService.divide(input.number_1, input.number_2);
        }


    }
}
