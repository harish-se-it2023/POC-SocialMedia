namespace SocialMediaIntegration;
using Reddit.NET.Client;
using SocialMediaIntegration.Interface;
using SocialMediaContract.Interface;
using SocialMediaContract;

public class RedditService : ISocialMediaService
{
    public ISocialMediaProvider _socialMediaProvider { get; set; }
    public ISocialMediaServiceAuthentication _socialMediaServiceAuthentication { get; set; }

    public IRedditPostsInfo RetrieveSamplePosts()
    {
        _socialMediaProvider.GetSocialMediaService(1);// social media vendor basically from config just hardcoded for POC

        var token = GetAuthenticationToken();

        // call the second reddit api to fetch the posts;
        //
        return new RedditPostInfo() { PostName = "Post-" + Guid.NewGuid() };

    }

    public string GetAuthenticationToken()
    {
        return _socialMediaServiceAuthentication.GetAuthenticationToken();

    }

}

