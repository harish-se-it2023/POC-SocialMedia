using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMediaManager;
using SocialMediaManager.Interface;
using SocialMediaContract.Interface;

namespace SocialMediaRestApi.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class SamplePostsController : ControllerBase
    {
        public ICreatePostsHandler _createRedditPostsHandler { get; set; }
        public IGetPostsHandler _getRedditPostsHandler { get; set; }


        [Route("collect")]
        [HttpPost]
        public async Task CollectSampleTweets()
        {
            //return await Task.FromResult<int>(GetSum(2, 3));
            await _createRedditPostsHandler.AddPosts();
        }

        [Route("show")]
        [HttpGet]
        public async Task<IRedditPostsInfoList> ShowSampleTweets()
        {
            //return await Task.FromResult<int>(GetSum(2, 3));
            return await _getRedditPostsHandler.ShowPosts();
        }


        private int GetSum(int x, int y)
        {
            return x + y;
        }
    }
}
