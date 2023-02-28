using System;
namespace SocialMediaContract.Interface
{
	public interface IRedditPostsInfoList
	{
        public IList<RedditPostInfo> RedditPostInfos { get; set; }
    }
}

