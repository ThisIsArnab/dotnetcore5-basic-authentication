using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeDuniya.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MemeDuniya.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemeFeedsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<MemeFeedsController> _logger;

        public MemeFeedsController(ILogger<MemeFeedsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Feed> Get()
        {
            throw new NotImplementedException();
        }
    }
}
