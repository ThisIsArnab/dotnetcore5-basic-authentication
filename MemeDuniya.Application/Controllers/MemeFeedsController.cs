using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeDuniya.Repository.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MemeDuniya.Application.Controllers
{
    [Authorize]
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
        [HttpGet("getFeeds")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<Feed>> GetFeeds()
        {
            var controllerUser = ControllerContext.HttpContext.User;
            var user = User;

            IList<Feed> feeds;
            if (user.Identity.IsAuthenticated)
            {
                feeds = new List<Feed> {
                    new Feed { UserName=user.Identity.Name, 
                        Comments = new List<Comment> {new Comment { Text=$"User Authenticated. Authentication type: {user.Identity.AuthenticationType}"}}}
                };
            }
            else
            {
                feeds = new List<Feed> {
                    new Feed { UserName=user.Identity.Name,  Comments = new List<Comment> {new Comment {Text="Not Authenticated"}}}
                };
            }
            return Ok(feeds);
        }

        /// <summary>
        /// Adds a feed from user.
        /// </summary>
        /// <param name="feed"></param>
        [HttpPost("addFeed")]
        public IActionResult AddFeed(Feed feed)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return at most 10 filtered feeds. Only indexed criteria allowed
        /// </summary>
        /// <returns></returns>
        [HttpGet("filterFeeds")]
        public ActionResult<IEnumerable<Feed>> FilterFeeds()
        {
            var feeds = new List<Feed> {
                new Feed { Id=1, Likes=10, Dislikes=1},
                new Feed { Id=2, Comments=null }
            };
            return Ok(feeds);
        }

        /// <summary>
        /// Inclue User feeds at top if authenticated.
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        [HttpGet("searchFeeds")]
        public IEnumerable<Feed> SearchFeeds(string[] keywords)
        {
            throw new NotImplementedException();
        }
    }
}
