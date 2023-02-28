namespace SocialMediaContract;
public class AppSettings
{
    public class Vendors
    {
       public string Name { get; set; }
       public Authentication Authentication { get; set; }
     
    }

    public class Authentication
    {

        public string ClientId { get; set; }
        public string Secret { get; set; }
        public string TokenEndPoint { get; set; }
        public string CredentialTokenScope { get; set; }
        public string ContentType { get; set; }

    }
}


