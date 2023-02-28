using System;
using SocialMediaManager.Interface;
using SocialMediaData.Interface;
using SocialMediaContract;
using SocialMediaContract.Interface;

namespace SocialMediaManager
{
	public class CreatePostsHandler : ICreatePostsHandler
    {
		public IRedditPostsRepository _redditPostsRepository { get; set; }

		public CreatePostsHandler(IRedditPostsRepository redditPostsRepository)
		{
			_redditPostsRepository = redditPostsRepository;
		}

		public async Task AddPosts()
		{
			//authenticate reddit service

			//call another reddit service to get needed info
			var post = new RedditPostInfo();
			_redditPostsRepository.AddPosts(post);

		}

        

    }
}
