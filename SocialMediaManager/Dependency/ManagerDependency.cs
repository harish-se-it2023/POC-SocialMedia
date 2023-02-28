using System;
using Microsoft.Extensions.DependencyInjection;
using SocialMediaIntegration.Dependency;
using SocialMediaData.Dependency;
using SocialMediaManager.Interface;
using SocialMediaManager;
namespace SocialMediaManager.Dependency
{
	public static class ManagerDependency
	{
		public static void Register(IServiceCollection serviceCollection)
		{
			SocialMediaProviderServiceCollectionExtension.AddIntegrationDependencies(serviceCollection);
			SocialMediaDataServiceCollectionExtension.AddIntegrationDependencies(serviceCollection);
			serviceCollection.AddScoped<ICreatePostsHandler, CreatePostsHandler>();
            serviceCollection.AddScoped<IGetPostsHandler, GetRedditPostsHandler>();

        }
	}
}

