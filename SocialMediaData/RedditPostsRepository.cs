using SocialMediaData.Interface;
using System;
using SocialMediaContract.Interface;
using SocialMediaContract;

namespace SocialMediaData
{
    public class RedditPostsRepository : IRedditPostsRepository
    {
        public IRedditPostsInfoList RedditPostsInfoList { get; set; }

        public void AddPosts(RedditPostInfo postInfo)
        {
            RedditPostsInfoList.RedditPostInfos.Add(postInfo);
        }

        public IRedditPostsInfoList ShowPosts()
        {
            return RedditPostsInfoList;
        }
       
    }
}

