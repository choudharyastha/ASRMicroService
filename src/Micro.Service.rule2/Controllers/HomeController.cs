using Micro.Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly Random _random = new Random();

        [HttpGet("")]
        public async Task<Result> Get()

        {
            Result result = new Result();

            int num = _random.Next(2);
            result.StepDescription.Add(new StepDescription("Initiated", num == 1 ));

            num = _random.Next(2);
            result.StepDescription.Add(new StepDescription("Verified Background", num == 1 ));

            num = _random.Next(2);
            result.StepDescription.Add(new StepDescription("Processed", num == 1 ));

            var a = result.StepDescription.Where(x => x.Status == false).FirstOrDefault();
            if (a == null)
                result.Status = true;
            else
                result.Status = false;
            Console.WriteLine("In microservice 2");
            await Task.Delay(1000);
            return (result);
        }
    }
}
