using System;
using Microsoft.Extensions.DependencyInjection;
using SocialMediaData.Interface;
using SocialMediaData;
using SocialMediaContract;
using SocialMediaContract.Interface;


namespace SocialMediaData.Dependency
{
	public static class SocialMediaDataServiceCollectionExtension
	{
        public static void AddIntegrationDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRedditPostsRepository, RedditPostsRepository>();
            serviceCollection.AddScoped<IRedditPostsInfo, RedditPostInfo>();

            // Singleton to persist the object till services is running. 
            serviceCollection.AddSingleton<IRedditPostsInfoList, RedditPostsInfoList>();

        }

    }
}

