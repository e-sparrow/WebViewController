using Birdhouse.Extended.WebViewController.Interfaces;

namespace Birdhouse.Extended.WebViewController
{
    public readonly struct WebViewBasicAuthInfo : IWebViewBasicAuthInfo
    {
        public WebViewBasicAuthInfo(string id, string password)
        {
            Id = id;
            Password = password;
        }
        
        public string Id
        {
            get;
        }

        public string Password
        {
            get;
        }
    }
}