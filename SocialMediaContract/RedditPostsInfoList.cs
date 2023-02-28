using System;
using SocialMediaContract.Interface;
namespace SocialMediaContract
{
	public class RedditPostsInfoList : IRedditPostsInfoList
    {
		public IList<RedditPostInfo> RedditPostInfos { get; set; }
	}
}

