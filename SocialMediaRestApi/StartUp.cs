using System;
using SocialMediaContract;
using Microsoft.AspNetCore.Mvc;
using SocialMediaManager.Dependency;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace SocialMediaRestApi
{
	public class StartUp
	{
		public IConfiguration Configuration { get; }
		public StartUp(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
			services.AddOptions();
			services.AddSingleton<ILogger>(sp =>
			{
				var logger = sp.GetService<ILogger<ControllerBase>>();
				return logger;
			});
			services.AddApplicationInsightsTelemetry(Configuration);
			ManagerDependency.Register(services);
			//services.AddAuthentication().AddOAuth("", null); -- get token parameters from config for token validaiton.
        }

	}
}

