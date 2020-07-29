using Microsoft.AspNetCore.Mvc;
using PrimeNumbers.Interfaces;

namespace PrimeNumbers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimeNumbersController : ControllerBase
    {
        private readonly IPrimeNumbersService primeNumberService;

        public PrimeNumbersController(IPrimeNumbersService primeNumbersService)
        {
            this.primeNumberService = primeNumbersService;            


        }

        [HttpGet]
        [Route("IsPrimeNumber/{number}")]
        public bool IsPrimeNumber(int number)
        {
            var result = primeNumberService.IsPrimeNumber(number);
            return result;            
        }

        [HttpGet]
        [Route("GetNextPrimeNumber/{number}")]
        public int GetNextPrimeNumber(int number)
        {
            var result = primeNumberService.GetNextPrimeNumber(number);
            return result;
        }
    }
}
