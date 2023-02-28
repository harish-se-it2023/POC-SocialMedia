using SocialMediaData.Interface;
using System;
using SocialMediaContract.Interface;
using SocialMediaContract;

namespace SocialMediaData.Interface
{
	public interface IRedditPostsRepository
    {
        public void AddPosts(RedditPostInfo postInfo);
        public IRedditPostsInfoList ShowPosts();
    }
}

