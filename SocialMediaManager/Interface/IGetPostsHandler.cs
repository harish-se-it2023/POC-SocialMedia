using System;
using SocialMediaContract.Interface;
namespace SocialMediaManager.Interface
{
	public interface IGetPostsHandler
	{
        public Task<IRedditPostsInfoList> ShowPosts();

    }
}

