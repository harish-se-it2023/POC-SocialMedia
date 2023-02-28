using System;
namespace SocialMediaIntegration.Interface
{
	public interface ISocialMediaProvider
	{
        public ISocialMediaService GetSocialMediaService(int i);

    }
}

