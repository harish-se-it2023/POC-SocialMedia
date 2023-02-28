using System;
using SocialMediaIntegration.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace SocialMediaIntegration
{
	public class SocialMediaProvider : ISocialMediaProvider
    {
		private readonly IServiceProvider _serviceProvider;
		public SocialMediaProvider(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public ISocialMediaService GetSocialMediaService(int i)
		{

			//Factory pattern
			if (i == 1) // Reddit
				return _serviceProvider.GetRequiredService<IRedditService>();// configured
			//if (i == 2)
				//return new Twitter();
			else
				return null;
		}

	}
}

