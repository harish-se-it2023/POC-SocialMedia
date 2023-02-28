using System;
using Microsoft.Extensions.DependencyInjection;
using SocialMediaIntegration.Interface;

namespace SocialMediaIntegration.Dependency
{
	public static class SocialMediaProviderServiceCollectionExtension
	{
		public static void AddIntegrationDependencies(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddScoped<ISocialMediaService, RedditService>();
            serviceCollection.AddScoped<ISocialMediaService, RedditService>();
            serviceCollection.AddScoped<ISocialMediaServiceAuthentication, RedditServiceAuthentication>();

        }
	}
}

