using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestRestApp.Controllers
{
    [Route("api/sample-tweets")]
    [ApiController]
    public class SampleTweetsController : ControllerBase
    {
        [Route("collect")]
        [HttpPost]
        public async Task<int> CollectSampleTweets()
        {
            return await Task.FromResult<int>(GetSum(2, 3));
        }

        [Route("show")]
        [HttpPost]
        public async Task<int> ShowSampleTweets()
        {
            return await Task.FromResult<int>(GetSum(2, 3));
        }


        private int GetSum(int x, int y)
        {
            return x+y;
        }
    }
}
