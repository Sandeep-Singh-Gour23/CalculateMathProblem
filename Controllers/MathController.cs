using CalculateMathProblem.Service_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculateMathProblem.Controllers
{
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
        public int Addition(int number_1, int number_2)
        {
            return _mathService.add(number_1, number_2);
        }


        [HttpPost]
        [Route("/subtract")]
        public int Subtraction(int number_1, int number_2)
        {
            return _mathService.subtract(number_1, number_2);
        }


        [HttpPost]
        [Route("/multiply")]
        public int Multiplication(int number_1, int number_2)
        {
            return _mathService.multiply(number_1, number_2);
        }

        [HttpPost]
        [Route("/divide")]
        public double Division(double number_1, double number_2)
        {
            return _mathService.divide(number_1, number_2);
        }


    }
}
