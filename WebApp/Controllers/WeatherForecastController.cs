using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public string GetName()
        {
            return "Stefan Brunotte";
        }
        [Route("getAge")]
        [HttpGet]
        public int GetAge()
        {
            return 50;
        }

        [Route("sendData")]
        public void SendData([FromBody] Person p) 
        {
            Console.WriteLine($"{p.FirstName} {p.LastName}");
        }
    }

}
