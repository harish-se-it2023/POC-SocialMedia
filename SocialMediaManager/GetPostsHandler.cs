using System;
using SocialMediaManager.Interface;
using SocialMediaData.Interface;
using SocialMediaContract.Interface;
namespace SocialMediaManager
{
	public class GetRedditPostsHandler : IGetPostsHandler
    {
        public IRedditPostsRepository _redditPostsRepository { get; set; }

        public GetRedditPostsHandler(IRedditPostsRepository redditPostsRepository)
        {
            _redditPostsRepository = redditPostsRepository;
        }

        public async Task<IRedditPostsInfoList> ShowPosts()
        {
            return _redditPostsRepository.ShowPosts();

        }
    }
}

