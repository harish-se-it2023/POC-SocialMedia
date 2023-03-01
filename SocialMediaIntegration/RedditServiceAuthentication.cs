using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using SocialMediaIntegration.Interface;

namespace SocialMediaIntegration
{
	public class RedditServiceAuthentication : ISocialMediaServiceAuthentication
	{
		public RedditServiceAuthentication()
		{
		}

		public string GetAuthenticationToken()
		{

            //Call first Reddit service to get token
            //return "";
            string encoded = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1")
                               .GetBytes("SHl1wE1Kd1GLeWm1nclC9A" + ":" + "5RxVIoykq4y5bh5hkH2Zu6xa4DlmvQ"));

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.clickatell.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsync("https://www.reddit.com/api/v1/access_token?grant_type=client_credentials", null).Result;
                // return response?.Content.ReadFromJsonAsync()?.access_token;
            }
            return "";
            
        }

	}
}

