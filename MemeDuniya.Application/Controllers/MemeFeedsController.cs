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
        private readonly ILogger<MemeFeedsController> _logger;

        public MemeFeedsController(ILogger<MemeFeedsController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Returns paginated list of Feeds. Default feed count is 10.
        /// Use cursor to get next set of feeds.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Feed> GetFeeds()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a feed from user.
        /// </summary>
        /// <param name="feed"></param>
        [HttpPost]
        public IActionResult AddFeed(Feed feed) 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return at most 10 filtered feeds. Only indexed criteria allowed
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Feed> FilterFeeds()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inclue User feeds at top if authenticated.
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Feed> SearchFeeds(string[] keywords)
        {
            throw new NotImplementedException();
        }
    }
}
