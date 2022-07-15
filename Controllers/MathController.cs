using CalculateMathProblem.Domain;
using CalculateMathProblem.Filters;
using CalculateMathProblem.Service_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculateMathProblem.Controllers
{
    [ServiceFilter(typeof(CalculateLogFilter))] // Controller level Filter

    [Route("api/[controller]")]
    [ApiController]

    public class MathController : ControllerBase
    {
        private readonly IMathService _mathService;

        public MathController(IMathService mathService)
        {
            _mathService = mathService;
        }

        [HttpPost]
        [Route("/add")]
        public int Addition([FromBody] domain input)
        {
            return _mathService.add(input.number_1, input.number_2);
        }


        [HttpPost]
        [Route("/subtract")]
        public int Subtraction([FromBody] domain input)
        {
            return _mathService.subtract(input.number_1, input.number_2);
        }


        [HttpPost]
        [Route("/multiply")]
        public int Multiplication([FromBody] domain input)
        {
            return _mathService.multiply(input.number_1, input.number_2);
        }

        [HttpPost]
        [Route("/divide")]
        public int Division([FromBody] domain input)
        {
            return _mathService.divide(input.number_1, input.number_2);
        }


    }
}
